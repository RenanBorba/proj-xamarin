// ApiService.cs
// 
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Evntr.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Evntr.Core.Services
{
    public class ApiService : IApiService
	{
        private Speaker joao = new Speaker
        {
            Name = "João Souza",
            Title = "Developer Xamarin",
            MiniBio = "Desenvolvedor Web ASP.NET e Mobile Xamarin, especialista em .NET, entusiasta open source, com 8 anos de experiência com Xamarin.",
            AvatarUrl = "joao.jpeg"
        };
        private Speaker joana = new Speaker
        {
            Name = "Joana Darc",
            Title = "Developer React Native",
            MiniBio = "27 anos, certificada em diversas plataformas e ferramentas, desenvolvedora Mobile, entusiasta em novas tecnologias!",
            AvatarUrl = "joana.jpeg"
        };
        private Speaker marcos = new Speaker
        {
            Name = "Marcos Gomes",
            Title = "Developer Ionic | Flutter",
            MiniBio = "Desenvolvedor há 11 anos, especialista em projetos Mobile híbridos.",
            AvatarUrl = "marcos.jpeg"
        };
        private Speaker gilberto = new Speaker
        {
            Name = "Gilberto Augusto",
            Title = "Developer PhoneGap Cordova",
            MiniBio = "Professor em universidades, desenvolvedor web e móvel, entusiasta em novas tecnologias!",
            AvatarUrl = "gilberto.jpeg"
        };

		public async Task<List<Talk>> GetSchedule()
		{
            return new List<Talk>
            {
                new Talk
                {
                    Title = "Introdução ao Xamarin",
                    Description= "O .NET é uma plataforma para desenvolvimento composta de ferramentas, linguagens de programação e bibliotecas para criar muitos tipos diferentes de aplicativos. O Xamarin estende a plataforma do desenvolvedor .NET com ferramentas e bibliotecas especificamente para a criação de aplicativos para Android, iOS, tvOS, watchOS, macOS e Windows.",
                    ScheduleDay = ScheduleDay.One,
                    Speaker = joao
                },
                new Talk
                {
                    Title = "Introdução ao React Native",
                    Description= "React Native é uma biblioteca Javascript criada pelo Facebook. É usada para desenvolver aplicativos para os sistemas Android e IOS de forma nativa.",
                    ScheduleDay = ScheduleDay.One,
                    Speaker = joana
                },
                new Talk
                {
                    Title = "Introdução ao Ionic",
                    Description= "O Ionic é um SDK de código aberto completo para o desenvolvimento de aplicativos móveis híbridos.",
                    ScheduleDay = ScheduleDay.One,
                    Speaker = marcos
                },
                new Talk
                {
                    Title = "Introdução ao Flutter",
                    Description= "Flutter é um SDK de código aberto criado pelo Google para o desenvolvimento de aplicativos para Android, iOS, Desktop ou Web, além de ser o principal método de criação de aplicativos para o Google Fuchsia.",
                    ScheduleDay = ScheduleDay.One,
                    Speaker = marcos
                },
                new Talk
                {
                    Title = "Introdução ao PhoneGap e Cordova",
                    Description = "PhoneGap é um framework para desenvolvimento de aplicativos móveis em código aberto. Ele se utiliza da tecnologia Apache Cordova para acessar a funções dos aparelhos móveis como acelerômetro, câmera e geolocalização, e permite por meio de alguns que os desenvolvedores criem aplicações utilizando HTML5, CSS3 e JavaScript sem a necessidade de depender de APIs específicas. Os aplicativos criados são compatíveis com iOS, Windows Phone e Android.",
                    ScheduleDay = ScheduleDay.One,
                    Speaker = gilberto
                }
            };
		}

		public async Task<Event> GetEvent()
		{
            return new Event
            {
                Name = "XV Conf IT 2019",
                LogoUrl = "logotipo.png",
                Speakers = new List<Speaker>
                {
                    joao, joana, marcos, gilberto
                }
            };
		}
	}
}
