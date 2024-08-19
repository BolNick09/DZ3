namespace DZ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //drawSquare(5, '*');
            //--------------------------------------------------------------------            

            //Console.WriteLine("Is 3443 palindrome? " + checkPalindrome(3443)); 
            //Console.WriteLine("Is 7854 palindrome? " + checkPalindrome(7854));
            //--------------------------------------------------------------------   

            //int[] origArr = { 1, 2, 6, -1, 88, 7, 6 };
            //int[] filArr = { 6, 88, 7 };
            //int[] filteredArray = filterArray(origArr, filArr);

            //foreach (int i in filteredArray) 
            //    Console.Write(i + " ");
            //--------------------------------------------------------------------   

            Website website = new Website("Google", "www.google.com", "Поисковая система", "8.8.8.8");

            Console.WriteLine("Название сайта: " + website.getName());
            Console.WriteLine("Путь к сайту: " + website.getUrl());
            Console.WriteLine("Описание сайта: " + website.getDescription());
            Console.WriteLine("IP-адрес сайта: " + website.getIpAddress());
            //--------------------------------------------------------------------   

        }

        static void drawSquare(int side, char symb)
        {
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)                
                    Console.Write(symb);
                
                Console.WriteLine();
            }
        }
        //--------------------------------------------------------------------   
        static bool checkPalindrome(int number)
        {
            string numberString = number.ToString();

            return numberString == new string(numberString.Reverse().ToArray());
        }
        //--------------------------------------------------------------------   

        static int[] filterArray(int[] origArr, int[] filArr)
        {

            int[] filteredArray = new int[origArr.Length];
            int filteredIndex = 0;

            for (int i = 0; i < origArr.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < filArr.Length; j++)
                {
                    if (origArr[i] == filArr[j])
                    {
                        found = true;
                        break;
                    }
                }

                // Если элемент не найден, добавить его в отфильтрованный массив
                if (!found)                
                    filteredArray[filteredIndex++] = origArr[i];              
            }

            Array.Resize(ref filteredArray, filteredIndex);//уменьшить размер до фактического

            return filteredArray;
        }
        //--------------------------------------------------------------------   

        class Website
        {
            private string name;
            private string url;
            private string description;
            private string ipAddress;

            public Website(string name, string url, string description, string ipAddress)
            {
                this.name = name;
                this.url = url;
                this.description = description;
                this.ipAddress = ipAddress;
            }

            public string getName()
            {
                return name;
            }

            public string getUrl()
            {
                return url;
            }

            public string getDescription()
            {
                return description;
            }

            public string getIpAddress()
            {
                return ipAddress;
            }
            public void setName (string name)
            {
                this.name = name; 
            }
            public void setUrl (string url)
            {
                this.url= url;
            }
            public void setDescription(string description)
            {
                this.description = description;
            }
            public void setIpAddress (string ipAddress)
            {
                this.ipAddress= ipAddress;
            }
            
        }
        //--------------------------------------------------------------------   

    }
}
