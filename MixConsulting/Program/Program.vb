Imports System.IO
Imports System.Windows.Forms
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.DependencyInjection
Imports MiX_Consulting.Infrastructure.Repositories

Public Module Program
    ' Expose the Service Provider globally within the Presentation tier so Forms can resolve downstream views if needed
    Public Property ServiceProvider As IServiceProvider

    <STAThread()>
    Public Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' 1. Build and parse appsettings.json file configuration
        Dim configBuilder = New ConfigurationBuilder().
            SetBasePath(Directory.GetCurrentDirectory()).
            AddJsonFile("appsettings.json", optional:=False, reloadOnChange:=True)
        Dim configuration As IConfiguration = configBuilder.Build()

        ' 2. Configure Service Collections (Register dependencies)
        Dim services = New ServiceCollection()

        ' Inject the standalone config instance
        services.AddSingleton(Of IConfiguration)(configuration)

        ' Inject Repositories as Transient (fresh instances per request window)
        services.AddTransient(Of UserRepository)()
        services.AddTransient(Of CompanyRepository)()

        ' Inject UI Forms directly into the DI engine
        services.AddTransient(Of frmLogin)()
        services.AddTransient(Of frmMain)()

        ' 3. Compile the provider container
        ServiceProvider = services.BuildServiceProvider()

        ' Attach the low-level security global activity filter loop
        Application.AddMessageFilter(New ActivityFilter())

        ' 4. Launch the Gateway dialog by resolving it cleanly out of the DI engine
        Using loginForm = ServiceProvider.GetRequiredService(Of frmLogin)()
            If loginForm.ShowDialog() = DialogResult.OK Then
                ' Resolve and execute main registry window workspace if identity maps confirm
                Dim mainForm = ServiceProvider.GetRequiredService(Of frmMain)()
                Application.Run(mainForm)
            Else
                Application.Exit()
            End If
        End Using
    End Sub
End Module