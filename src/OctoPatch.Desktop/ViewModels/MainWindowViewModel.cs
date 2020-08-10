using System.Threading;
using System.Xaml;
using DynamicData;
using NodeNetwork.ViewModels;
using ReactiveUI;

namespace OctoPatch.Desktop.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {

        public NetworkViewModel NetworkViewModel { get;  }

        public MainWindowViewModel()
        {
            NetworkViewModel = new NetworkViewModel();

            var node1 = new NodeViewModel { Name = "Input Node" };
            var node2 = new NodeViewModel() { Name = "Output Node" };

            node1.Inputs.Add(new NodeInputViewModel());
            node2.Outputs.Add(new NodeOutputViewModel());

            NetworkViewModel.Nodes.Add(node1);
            NetworkViewModel.Nodes.Add(node2);

        }
    }
}