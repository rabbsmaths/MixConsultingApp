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

        ' Build configuration from appsettings.json
        Dim configBuilder = New ConfigurationBuilder().
            SetBasePath(Directory.GetCurrentDirectory()).
            AddJsonFile("appsettings.json", optional:=False, reloadOnChange:=True)
        Dim configuration As IConfiguration = configBuilder.Build()

        ' Setup Dependency Injection container
        Dim services = New ServiceCollection()
        services.AddSingleton(Of IConfiguration)(configuration)

        ' Register Repositories
        services.AddTransient(Of MiX_Consulting.Domain.Interfaces.ICompanyRepository, CompanyRepository)()
        services.AddTransient(Of UserRepository)()
        services.AddTransient(Of CompanyRepository)()
        services.AddTransient(Of AddressRepository)()
        services.AddTransient(Of IRepresentativeRepository, RepresentativeRepository)()


        ' Register Forms (Using frmDashboard to resolve the layout engine caching loop)
        services.AddTransient(Of frmLogin)()
        services.AddTransient(Of frmDashboard)()
        services.AddTransient(Of FrmCompanyManagement)()
        services.AddTransient(Of FrmAddressManagement)()
        services.AddTransient(Of FrmRepresentativeManagement)()

        ' Build the provider
        ServiceProvider = services.BuildServiceProvider()
        Application.AddMessageFilter(New ActivityFilter())

        ' Run application lifecycle through DI container
        Using loginForm = ServiceProvider.GetRequiredService(Of frmLogin)()
            If loginForm.ShowDialog() = DialogResult.OK Then
                ' Pull and run our fresh dashboard workspace container
                Dim mainDashboard = ServiceProvider.GetRequiredService(Of frmDashboard)()
                Application.Run(mainDashboard)
            Else
                Application.Exit()
            End If
        End Using
    End Sub
End Module