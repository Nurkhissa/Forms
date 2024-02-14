while (true)
            {
                Console.WriteLine(
                    "1.Square\n" +
                    "2.Triangle\n" +
                    "3. Stop\n"
                    );

                Console.Write(">");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if(n==1)
                {
                    int width = 4;
                    char asterisk = '*';
                    char hash = '#';
                    int counter = 0;
                    for (int h = 0; h < 6; h++) 
                    {
                        for (int w = 0; w < width; w++) 
                        {
                            if (h == counter)
                                Console.Write (asterisk);
                            else
                                Console.Write (hash);
                        }       
                        counter++;

                        Console.WriteLine ();
                    }
                }
                    else if(n==2)
                    {
                        int val = 5;  
                        int i, j, k ;  
                        for (i = 1; i <= val; i++)  
                            {  
                                for (j = 1; j <= val-i; j++)  
                                    {  
                                        // Console.Write("");  
                                    }  
                                        for (k = 1; k <= i; k++)  
                                            {  
                                                Console.Write("*");  
                                            }  
                                        Console.WriteLine("");  
                    
                            }
                    }
                else if(n==3)
                break;
            }  