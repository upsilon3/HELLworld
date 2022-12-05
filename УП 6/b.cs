int[] source = { -1, 15, 16, 24, 16, -5, -7, 234};
            int[] next = new int[source.Length];
            for(int i = 0; i < source.Length; i++)
            {
                if(source[i] > 0 || source[i] == 0)
                    next[i] = source[i];
                else
                    next[i] = 3;
            }
            Console.Write("Source: ");
            foreach(int i in source)
                Console.Write(i + " ");
            Console.Write("\nNew: ");
            foreach(int i in next)
                Console.Write(i + " ");
            Console.ReadKey(true);
