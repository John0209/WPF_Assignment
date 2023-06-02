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
            services.AddSingleton<LoginForm>();
            services.AddSingleton<ProductForm>();
            services.AddSingleton<AddProduct>();
            services.AddSingleton<NodifyForm>();
            services.AddSingleton<UpdateProduct>();
        }
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var loginPage = serviceProvider.GetService<LoginForm>();
            var productPage = serviceProvider.GetService<ProductForm>();
            var addPage = serviceProvider.GetService< AddProduct>();
            var nodifyPage = serviceProvider.GetService<NodifyForm>();
            var updatePage = serviceProvider.GetService<UpdateProduct>();
            productPage.Show();
        }

    }
}
