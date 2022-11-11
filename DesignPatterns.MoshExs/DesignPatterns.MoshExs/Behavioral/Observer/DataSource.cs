
namespace DesignPatterns.MoshExs.Behavioral.Observer
{
    public class DataSource : ObservableSubject
    {
        private string _Value;
        public string Value { get => _Value; 
            set
            { 
                _Value = value;
                NotifyObservers();
            }
        }        
    }
}
