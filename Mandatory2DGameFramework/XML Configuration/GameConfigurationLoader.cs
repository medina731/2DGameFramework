using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Mandatory2DGameFramework.XML_Configuration
{
    internal static class GameConfigurationLoader
    {
        public static GameConfiguration Load(string filePath)
        {
            GameConfiguration config = new GameConfiguration();

            using (XmlReader reader = XmlReader.Create(filePath))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "MaxX":
                                config.MaxX = reader.ReadElementContentAsInt();
                                break;

                            case "MaxY":
                                config.MaxY = reader.ReadElementContentAsInt();
                                break;

                            case "Difficulty":
                                config.Difficulty = reader.ReadElementContentAsString();
                                break;
                        }
                    }
                }
            }

            return config;
        }
    }
} 

