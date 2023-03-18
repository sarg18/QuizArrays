namespace QuizArray.Logic
{
 public class TwoDimensions
    {

        private int[,] _array;
      
        public TwoDimensions(int _m, int _n)
        {
            M = _m;
            N = _n;
            _array = new int[_m, _n];
        }

        public int N { get; }
        public int M { get; }



        public override string ToString()
        {
            var output = string.Empty;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    output += $"{_array[i, j]}\t";
                }
                output += "\n";
            }
            return output;
        }


        public void Fill()
        {
            Fill(1, 100);
        }

        public void Fill(int min, int max)
        {
            var random = new Random();
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    _array[i, j] = random.Next(min, max);
                }
            }
        }

        public string ToOneDimension()
        {
            var output = string.Empty;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    output += $"{_array[i, j]}\t";
                }
            }
            return output;
        }

    }   
}
