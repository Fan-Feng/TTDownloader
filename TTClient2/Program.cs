using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTClient2.ServiceReference1;


namespace TTClient2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataServiceClient client = new DataServiceClient();
            DateTime start = Convert.ToDateTime("2015-1-1");
            DateTime end = Convert.ToDateTime("2016-1-1");
            object[][] SubItems;

            SubItems = client.GetSubItems();

            /*
            DateTime start = Convert.ToDateTime("2015-1-1");
            DateTime end = Convert.ToDateTime("2016-1-1");
            */

            /*
            object[][] m;
            m = client.GetMeterInfo("310105A008");
            int a = 1;
            */

            /*
            object[][] c;
            c = client.GetMeterData("310105A008",start,end,15, "310105A008M055");
            */



            /*
            //Download all MeterData
            DateTime start = Convert.ToDateTime("2015-1-1");
                DateTime end = Convert.ToDateTime("2016-1-1");
                int k;
                for (k=192;k<=201;k++)
                {
                    object[][] cInfo, c;

                    cInfo = client.GetCircuitInfoData(buildingId[k-1]);

                    for (j =0 ; j < cInfo.GetLength(0); j++)
                    {
                        c = client.GetCircuitEnergyData(buildingId[k - 1], cInfo[j][0].ToString(), start, end, 15);
                        Console.WriteLine(c.GetLength(0));

                        string delimiter = ",";
                        List<string[]> output = new List<string[]>();

                        string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\" + buildingId[k - 1];
                        if (!Directory.Exists(pathDesktop))
                        {
                            Directory.CreateDirectory(pathDesktop);
                        }
                        string fileName = pathDesktop +"\\" + cInfo[j][0].ToString() + ".csv";
                        if (!File.Exists(fileName))
                        {
                            File.Create(fileName).Close();
                        }

                        int i;
                        for (i = 0; i < c.GetLength(0); ++i)
                        {
                            output.Add(new string[] { c[i][0].ToString(), c[i][1].ToString(),c[i][2].ToString(), c[i][3].ToString(),
                        c[i][4].ToString()});
                        }

                        using (System.IO.TextWriter writer = File.CreateText(fileName))
                        {
                            for (i = 0; i < c.GetLength(0); i++)
                            {
                                writer.WriteLine(string.Join(delimiter, output[i]));
                            }
                        }
                    }
                }
                */


            //Building information
            /*
            object[][] c;
           
            c = client.GetBuildInfo("310105H001");
            Console.WriteLine("建筑编号：{0}，建筑名称：{1}，{2}，{3}，{4}，{5}，{6}，{7}", c[0][0],
                c[0][1], c[0][2], c[0][3], c[0][4], c[0][5], c[0][6], c[0][7]);
           */

            /*
            int j;
            string delimiter = ",";
            List<string[]> output = new List<string[]>();

            string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = pathDesktop + "\\buildingInfo.csv";
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
            }

            for (j=1;j<=4;j++)
            {
                object[][] c;
                string blgId = "310105E00" + j.ToString();
                c = client.GetBuildInfo(blgId);
                Console.WriteLine("建筑编号：{0}，建筑名称：{1}，{2}，{3}，{4}，{5}，{6}，{7}", c[0][0],
                    c[0][1], c[0][2], c[0][3], c[0][4], c[0][5], c[0][6], c[0][7]);

                output.Add(new string[] { c[0][0].ToString(), c[0][1].ToString(), c[0][2].ToString(),
                 c[0][3].ToString(), c[0][4].ToString(), c[0][5].ToString(), c[0][6].ToString(), c[0][7].ToString()});
            }
            for (j = 10; j <= 16; j++)
            {
                object[][] c;
                string blgId = "310105G0" + j.ToString();
                c = client.GetBuildInfo(blgId);
                Console.WriteLine("建筑编号：{0}，建筑名称：{1}，{2}，{3}，{4}，{5}，{6}，{7}", c[0][0],
                    c[0][1], c[0][2], c[0][3], c[0][4], c[0][5], c[0][6], c[0][7]);

                output.Add(new string[] { c[0][0].ToString(), c[0][1].ToString(), c[0][2].ToString(),
                 c[0][3].ToString(), c[0][4].ToString(), c[0][5].ToString(), c[0][6].ToString(), c[0][7].ToString()});
            }
            
            for (j = 100; j <= 115; j++)
            {
                object[][] c;
                string blgId = "310105A" + j.ToString();
                c = client.GetBuildInfo(blgId);
                Console.WriteLine("建筑编号：{0}，建筑名称：{1}，{2}，{3}，{4}，{5}，{6}，{7}", c[0][0],
                    c[0][1], c[0][2], c[0][3], c[0][4], c[0][5], c[0][6], c[0][7]);

                output.Add(new string[] { c[0][0].ToString(), c[0][1].ToString(), c[0][2].ToString(),
                 c[0][3].ToString(), c[0][4].ToString(), c[0][5].ToString(), c[0][6].ToString(), c[0][7].ToString()});
            }
            
            using (System.IO.TextWriter writer = File.CreateText(fileName))
            {
                for (j = 0; j <=22; j++)
                {
                    writer.WriteLine(string.Join(delimiter, output[j]));
                }
            }
              */

            // Metering data
            // Console.WriteLine(client.GetMeterInfo("310105A008"));


            // All building
            List<string> buildingId = new List<string>();
            int j;
            for (j = 1; j <= 9; j++)
            {
                buildingId.Add("310105A00" + j.ToString());
            }
            for (j = 10; j <= 99; j++)
            {
                buildingId.Add("310105A0" + j.ToString());
            }
            for (j = 100; j <= 115; j++)
            {
                buildingId.Add("310105A" + j.ToString());
            }

            for (j = 1; j <= 9; j++)
            {
                buildingId.Add("310105B00" + j.ToString());
            }
            for (j = 10; j <= 24; j++)
            {
                buildingId.Add("310105B0" + j.ToString());
            }

            for (j = 1; j <= 9; j++)
            {
                buildingId.Add("310105C00" + j.ToString());
            }
            for (j = 10; j <= 31; j++)
            {
                buildingId.Add("310105C0" + j.ToString());
            }
            for (j = 1; j <= 7; j++)
            {
                buildingId.Add("310105D00" + j.ToString());
            }
            for (j = 1; j <= 4; j++)
            {
                buildingId.Add("310105E00" + j.ToString());
            }
            for (j = 1; j <= 3; j++)
            {
                buildingId.Add("310105F00" + j.ToString());
            }
            for (j = 1; j <= 9; j++)
            {
                buildingId.Add("310105G00" + j.ToString());
            }
            for (j = 10; j <= 16; j++)
            {
                buildingId.Add("310105G0" + j.ToString());
            }
            buildingId.Add("310105H001");

            /*
            Console.WriteLine("lalal");


            string delimiter = ",";
            List<string[]> output = new List<string[]>();


            string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = pathDesktop + "\\mycsvfile.csv";
            //string fileName = "C:\\FirstOutput.csv";
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
            }

            int i;
            for(i=0;i<c.GetLength(0);++i)
            {
                Console.WriteLine("ID:{0},name:{1}",c[i][0],c[i][1]);
                output.Add(new string[] { c[i][0].ToString(), c[i][1].ToString() });
            }

            using (System.IO.TextWriter writer = File.CreateText(fileName))
            {
                for(i=0;i<c.GetLength(0);i++)
                {
                    writer.WriteLine(string.Join(delimiter, output[i]));
                }
            }
            */

            /*
            // all building, meter information 
            for (j = 0; j < buildingId.GetLength(0); j++)
            {
                output.Clear();
                c = client.GetMeterInfo(buildingId[j]);

                fileName = pathDesktop + "\\"+buildingId[j]+".csv";
                //string fileName = "C:\\FirstOutput.csv";
                if (!File.Exists(fileName))
                {
                    File.Create(fileName).Close();
                }

                for (i = 0; i < c.GetLength(0); ++i)
                {
                    Console.WriteLine("ID:{0},name:{1}", c[i][0], c[i][1]);
                    output.Add(new string[] { c[i][0].ToString(), c[i][1].ToString() });
                }

                using (System.IO.TextWriter writer = File.CreateText(fileName))
                {
                    for (i = 0; i < c.GetLength(0); i++)
                    {
                        writer.WriteLine(string.Join(delimiter, output[i]));
                    }
                }

            }
            */
            /*
            //Download all circuitInformation Data
            List<string[]> output = new List<string[]>();
            string delimiter = ",";
            int k;
            for (k = 1; k <= 201; k++)
            {
                object[][] cInfo;
                output.Clear();

                cInfo = client.GetCircuitInfoData(buildingId[k - 1]);
               // Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}",cInfo[0][0], cInfo[0][1], cInfo[0][2],
                 //   cInfo[0][2], cInfo[0][3], cInfo[0][4], cInfo[0][5], cInfo[0][6], cInfo[0][7], cInfo[0][8],
                  //  cInfo[0][9], cInfo[0][10], cInfo[0][11], cInfo[0][12], cInfo[0][13]);

                string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) ;

                string fileName = pathDesktop + "\\" + buildingId[k-1] + ".csv";
                if (!File.Exists(fileName))
                {
                    File.Create(fileName).Close();
                }
                
                int i;
                for (i = 0; i < cInfo.GetLength(0); ++i)
                {
                    output.Add(new string[] { cInfo[i][0].ToString(), cInfo[i][1].ToString(),cInfo[i][2].ToString(), cInfo[i][3].ToString(),
                        cInfo[i][4].ToString(),cInfo[i][5].ToString(), cInfo[i][6].ToString(),cInfo[i][7].ToString(), cInfo[i][8].ToString(),
                    cInfo[i][9].ToString(), cInfo[i][10].ToString(),cInfo[i][11].ToString(), cInfo[i][12].ToString(), cInfo[i][13].ToString()});
                }

                using (System.IO.TextWriter writer = File.CreateText(fileName))
                {
                    for (i = 0; i < cInfo.GetLength(0); i++)
                    {
                        writer.WriteLine(string.Join(delimiter, output[i]));
                    }
                }


            }
            */







            //Download all circuitEnergyData
            int k;
            for (k = 1; k <= 201; k++)
            {
                object[][] hvac, total;
                hvac = client.GetSelectedSubEnergy(buildingId[k - 1], start, end, "U2000", 0);
                Console.WriteLine(hvac.GetLength(0));

                string delimiter = ",";
                List<string[]> output = new List<string[]>();

                string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + buildingId[k - 1];
                if (!Directory.Exists(pathDesktop))
                {
                    Directory.CreateDirectory(pathDesktop);
                }
                string fileName = pathDesktop + "\\" + "hvac.csv";
                if (!File.Exists(fileName))
                {
                    File.Create(fileName).Close();
                }

                int i;
                for (i = 0; i < hvac.GetLength(0); ++i)
                {
                    output.Add(new string[] { hvac[i][0].ToString(), hvac[i][1].ToString(),hvac[i][2].ToString(), hvac[i][3].ToString(),
                        hvac[i][4].ToString()});
                }

                using (System.IO.TextWriter writer = File.CreateText(fileName))
                {
                    for (i = 0; i < hvac.GetLength(0); i++)
                    {
                        writer.WriteLine(string.Join(delimiter, output[i]));
                    }
                }


                total = client.GetSelectedSubEnergy(buildingId[k - 1], start, end, "U0000", 0);
                Console.WriteLine(total.GetLength(0));

                List<string[]> output2 = new List<string[]>();
                fileName = pathDesktop + "\\" + "total.csv";
                if (!File.Exists(fileName))
                {
                    File.Create(fileName).Close();
                }

                for (i = 0; i < total.GetLength(0); ++i)
                {
                    output2.Add(new string[] { total[i][0].ToString(), total[i][1].ToString(),total[i][2].ToString(), total[i][3].ToString(),
                        total[i][4].ToString()});
                }

                using (System.IO.TextWriter writer = File.CreateText(fileName))
                {
                    for (i = 0; i < total.GetLength(0); i++)
                    {
                        writer.WriteLine(string.Join(delimiter, output2[i]));
                    }
                }

            }


            Console.WriteLine("aa");
            client.Close();

        }
    }
}
               




                /*

                //GetCirCuitInfoData, and then write that in a .csv file
                object[][] c;
                c = client.GetCircuitInfoData("310105A076");
                Console.WriteLine(c[1].GetLength(0));
                Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}",
                    c[0][0], c[0][1], c[0][2], c[0][3], c[0][4], c[0][5],
                    c[0][6], c[0][7], c[0][8], c[0][9], c[0][10], c[0][11],
                    c[0][12], c[0][13]);

                string delimiter = ",";
                List<string[]> output = new List<string[]>();

                string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string fileName = pathDesktop + "\\JQDS\\circuitInfo.csv";
                if (!File.Exists(fileName))
                {
                    File.Create(fileName).Close();
                }

                int i;
                for (i = 0; i < c.GetLength(0); ++i)
                {
                    Console.WriteLine("ID:{0},name:{1}", c[i][0], c[i][1]);
                    output.Add(new string[] { c[i][0].ToString(), c[i][1].ToString(),c[i][2].ToString(), c[i][3].ToString(),
                        c[i][4].ToString(), c[i][5].ToString(),c[i][6].ToString(), c[i][7].ToString(),c[i][8].ToString(), c[i][9].ToString(),
                    c[i][10].ToString(), c[i][11].ToString(),c[i][12].ToString(), c[i][13].ToString()});
                }

                using (System.IO.TextWriter writer = File.CreateText(fileName))
                {
                    for (i = 0; i < c.GetLength(0); i++)
                    {
                        writer.WriteLine(string.Join(delimiter, output[i]));
                    }
                }
                */
