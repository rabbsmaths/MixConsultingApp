Imports System.IO
Imports System.Windows.Forms
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.DependencyInjection
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
        services.AddTransient(Of UserRepository)()
        services.AddTransient(Of CompanyRepository)()

        ' Register Forms (Updated names to fix Capitalization/Naming Rule Violations)
        services.AddTransient(Of frmLogin)()
        services.AddTransient(Of frmMain)()

        ' Build the provider
        ServiceProvider = services.BuildServiceProvider()
        Application.AddMessageFilter(New ActivityFilter())

        ' Run application lifecycle through DI container
        Using loginForm = ServiceProvider.GetRequiredService(Of frmLogin)()
            If loginForm.ShowDialog() = DialogResult.OK Then
                Dim mainForm = ServiceProvider.GetRequiredService(Of frmMain)()
                Application.Run(mainForm)
            Else
                Application.Exit()
            End If
        End Using
    End Sub
End Module