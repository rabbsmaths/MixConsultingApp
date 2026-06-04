Imports System.IO
Imports System.Windows.Forms
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.DependencyInjection
Imports MiX_Consulting.Domain.Interfaces
Imports MiX_Consulting.Infrastructure.Repositories

Public Module Program
    Public Property ServiceProvider As IServiceProvider

    <STAThread()>
    Public Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' 1. Build configuration from appsettings.json
        Dim configBuilder = New ConfigurationBuilder().
            SetBasePath(Directory.GetCurrentDirectory()).
            AddJsonFile("appsettings.json", optional:=False, reloadOnChange:=True)
        Dim configuration As IConfiguration = configBuilder.Build()

        ' 2. Setup Dependency Injection container
        Dim services = New ServiceCollection()
        services.AddSingleton(Of IConfiguration)(configuration)

        ' Register Repositories
        services.AddTransient(Of ICompanyRepository, CompanyRepository)()
        services.AddTransient(Of UserRepository)()
        services.AddTransient(Of CompanyRepository)()
        services.AddTransient(Of AddressRepository)()
        services.AddTransient(Of IRepresentativeRepository, RepresentativeRepository)()

        ' Register Forms
        services.AddTransient(Of frmLogin)()
        services.AddTransient(Of frmDashboard)()
        services.AddTransient(Of FrmCompanyManagement)()
        services.AddTransient(Of FrmAddressManagement)()
        services.AddTransient(Of FrmRepresentativeManagement)()

        ' Build the provider
        ServiceProvider = services.BuildServiceProvider()
        Application.AddMessageFilter(New ActivityFilter())

        ' 3. Run application lifecycle in a loop to handle session expiry re-authentication
        Do
            Dim shouldExit As Boolean = False

            Using loginForm = ServiceProvider.GetRequiredService(Of frmLogin)()
                ' If the user logs in successfully (DialogResult.OK)
                If loginForm.ShowDialog() = DialogResult.OK Then

                    ' Pull a fresh dashboard instance for the new session
                    Using mainDashboard = ServiceProvider.GetRequiredService(Of frmDashboard)()
                        mainDashboard.ShowDialog()
                    End Using

                    ' After the dashboard closes (due to logout or timeout), 
                    ' the loop repeats and shows the login screen again.
                Else
                    ' If the user cancels the login, we break the loop
                    shouldExit = True
                End If
            End Using

            If shouldExit Then Exit Do
        Loop
    End Sub
End Module