using System;

namespace Task_1._1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] _params = new string[3];
            ShowParams(_params);

            while (true)
            {
                Console.Write("Enter:{0}\t1: bold{0}\t2: italic{0}\t3: underline{0}", Environment.NewLine);

                bool succes = int.TryParse(Console.ReadLine(), out int number);

                if (succes && number > 0 && number < 4)
                    ChangeParams(ref _params, number);
                else
                    Console.WriteLine("Enter number 1-3, please");
            }
            
        }

        public static void ShowParams(string[] _params)
        {
            Console.Write("Parameters: ");

            int count = 0;
            foreach (var item in _params)
            {
                if (item != null)
                {
                    count++;
                    Console.Write($"{item} ");
                }
            }
            if (count == 0)
                Console.Write("None");
            Console.WriteLine();
        }

        public static void ChangeParams(ref string[] _params, int number)
        {
            string[] newParams = new string[_params.Length];

            switch (number)
            {
                case 1:
                    if (_params[0] == null)
                        newParams[0] = "Bold";
                    else
                        newParams[0] = null;
                    break;
                case 2:
                    if (_params[1] == null)
                        newParams[1] = "Italic";
                    else
                        newParams[1] = null;
                    break;
                case 3:
                    if (_params[2] == null)
                        newParams[2] = "Underline";
                    else
                        newParams[2] = null;
                    break;
            }
            for (int i = 0; i < _params.Length; i++)
            {
                if (_params[i] != null && i != number - 1)
                    newParams[i] = _params[i];
            }
            _params = newParams;
            ShowParams(_params);
        }
    }
}
