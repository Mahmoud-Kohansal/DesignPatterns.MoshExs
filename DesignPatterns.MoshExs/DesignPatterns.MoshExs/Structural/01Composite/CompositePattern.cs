
namespace DesignPatterns.MoshExs.Structural.Composite
{
    public static class CompositePattern
    {
        public static void Run()
        {
            Circle circle1 = new();
            Circle circle2 = new();
            Group group1 = new();
            group1.AddComponent(circle1);
            group1.AddComponent(circle2);

            Square square1 = new();
            Square square2 = new();
            Group group2 = new();
            group2.AddComponent(square1);
            group2.AddComponent(square2);

            Group group3 = new();
            group3.AddComponent(group1);
            group3.AddComponent(group2);

            group3.Render();

        }
    }
}
