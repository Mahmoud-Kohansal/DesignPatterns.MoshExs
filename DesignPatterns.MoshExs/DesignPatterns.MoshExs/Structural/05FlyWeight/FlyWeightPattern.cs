namespace DesignPatterns.MoshExs.Structural.FlyWeight
{
    public static class FlyWeightPattern
    {
        public static void Run()
        {
            PointService pointService = new(new PointIconFactory());
            foreach (var point in pointService.GetPoints())
            {
                point.Draw();
            }
        }
    }
}
