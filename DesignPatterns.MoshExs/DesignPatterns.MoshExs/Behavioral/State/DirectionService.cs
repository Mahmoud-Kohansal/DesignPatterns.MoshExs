
namespace DesignPatterns.MoshExs.Behavioral.State
{
    public class DirectionService
    {
        private ITravel _Travel;

        public DirectionService(ITravel travel)
        {
            _Travel = travel;
        }

        public void GetETA()
        {
            _Travel.GetETA();
        }
        public void GetDirection()
        {
            _Travel.GetDirection();
        }

        public ITravel GetTravel()
        {
            return _Travel;
        }
        public void SetTravel(ITravel travel)
        {
            _Travel = travel;
        }
    }

}
