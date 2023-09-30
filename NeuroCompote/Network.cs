namespace NeuroCompote
{
    public class Network
    {
        public List<Layer> Layers { get; set; }
        public Layer InputLayer { get; set; }

        private void createNetwork(double[] inputs, int outputValue, int[] neuronsInLayers)
        {
            this.InputLayer = new Layer(inputs);
            this.Layers.Add(this.InputLayer);

            for (var i = 0; i < neuronsInLayers.Length; i += 1)
            {
                this.Layers.Add(new Layer(this.Layers.Last(), neuronsInLayers[i])); //  проверить в каком порядке добавляются в список и поправить на фирст
            }
        }

        public Network(double[] inputs, int outputValue, int[] neuronsInLayers)
        {
            createNetwork(inputs, outputValue, neuronsInLayers);
        }
    }
}