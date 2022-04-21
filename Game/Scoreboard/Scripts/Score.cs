namespace TecEduFURB.Scoreboard {

    /// <summary>
    /// Representação de uma pontuação, composta por um nome e um valor.
    /// </summary>
    public class Score {

        public string Name { get; set; }
        public int Value { get; set; }

        public Score() { }

        public Score(string name, int value) {
            this.Name = name;
            this.Value = value;
        }
    }

}