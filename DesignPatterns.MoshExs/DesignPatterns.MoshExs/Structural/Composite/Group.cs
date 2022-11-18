

namespace DesignPatterns.MoshExs.Structural.Composite
{
    public class Group : IComponent
    {
        private List<IComponent> _Components = new();

        public void AddComponent(IComponent component)
        {
            _Components.Add(component);
        }

        public void Render()
        {
            foreach (var component in _Components)
            {
                component.Render();
            }
        }
    }
}
