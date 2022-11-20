namespace DesignPatterns.MoshExs.Structural.Decorator
{
    public static class DecoratorPattern
    {
        public static void Run()
        {
            //compress -> Encrypt -> Cloud
            IStream stream = new CompressedStream(new EncryptedStream(new CloudStream()));
            stream.Write("Mahmoud Kohansal");
        }
    }
}
