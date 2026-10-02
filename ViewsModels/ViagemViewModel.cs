using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoViagem.Models;
using CommunityToolkit.Mvvm.Input;

namespace ProjetoViagem.ViewsModels
{
    public partial class ViagemViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<ViagemModel> _viagem;

        [ObservableProperty]
        private List<ViagemViewModel> _viagemList;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsLastPosicao))]
        [NotifyPropertyChangedFor(nameof(ExibirBotao))]
        private int _posicao;
        public bool IsLastPosicao => Posicao == Viagem.Count - 1;

        public bool ExibirBotao => !IsLastPosicao;

        public ViagemViewModel()
        {
            Viagem = new List<ViagemModel>
            {
               new ViagemModel{
                  Titulo = "Explore \r\nExotic Destinations",
                 Descricao = "mbark on a virtual journey through stunning destinations worldwide.",
                 ImagemUrl = "image1m.png"
               },
               new ViagemModel{
                  Titulo = "Discover \r\nLocal Gems",
                 Descricao = "Uncover hidden gems and local favorites recommended by fellow travelers.",
                 ImagemUrl = "image2m.png"
               },
                 new ViagemModel{
                  Titulo = "Plan \r\nYour Perfect Trip",
                 Descricao = "Create personalized itineraries tailored to your preferences and interests.",
                 ImagemUrl = "image3m.png"
               },
                   new ViagemModel{
                  Titulo = "Capture and Share \r\nMemories",
                 Descricao = "Preserve your travel memories with our in-app photo and journaling features.",
                 ImagemUrl = "image4m.png"
               }

            };

        }
        [RelayCommand]
        private void Proximo()
        {
            if (Posicao < Viagem.Count - 1)
            {
                Posicao++;
            }
        }

    }
}