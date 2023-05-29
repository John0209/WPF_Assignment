using DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SalesWPFApp
{
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureService(services);
            serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureService(ServiceCollection services)
        {
            services.AddSingleton(typeof(IMemberRepository),typeof(MemberRepository));
            services.AddSingleton(typeof(IProductRepository), typeof(ProductRepository));
            services.AddSingleton<MainWindow>();
            services.AddSingleton<HomePage>();
        }
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow=serviceProvider.GetService<MainWindow>();
            var homePage=serviceProvider.GetService<HomePage>();
            homePage.Show();
        }
    }
}
