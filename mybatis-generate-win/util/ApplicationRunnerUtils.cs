using mybatis_generate_win.database;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mybatis_generate_win.util
{
    /// <summary>
    /// Application runner utils
    /// </summary>
    public class ApplicationRunnerUtils
    {

        /// <summary>
        /// Run the generator (*.bat or *.jar)
        /// </summary>
        /// <param name="TargetRuntime">targetRuntime. e.g : MyBatis3</param>
        /// <param name="ConnectionUrl">connectionUrl. e.g : jdbc:mysql://localhost:3306/wms?characterEncoding=utf-8</param>
        /// <param name="UserId">userId</param>
        /// <param name="Password">password</param>
        /// <param name="IsForceBigDecimals">isForceBigDecimals</param>
        /// <param name="IsEnableSubPackages">isEnableSubPackages</param>
        /// <param name="IsTrimStrings">isTrimStrings</param>
        /// <param name="ModelPackage">modelPackage</param>
        /// <param name="JavaMapperPackage">javaMapperPackage</param>
        /// <param name="XmlMapperPackage">xmlMapperPackage</param>
        /// <param name="TableNames">TableNames</param>
        /// <param name="Src">Src</param>
        public static void SerializeRun(string TargetRuntime, string ConnectionUrl, string UserId,
                                        string Password, string ModelPackage, string JavaMapperPackage,
                                        string XmlMapperPackage, bool IsForceBigDecimals, bool IsEnableSubPackages,
                                        bool IsTrimStrings, string TableNames, string Src)
        {
            ConfigFileBuilder fileBuilder = ConfigFileBuilder.getInstance(TargetRuntime, ConnectionUrl, UserId, Password,
                                                                          ModelPackage, JavaMapperPackage, XmlMapperPackage,
                                                                          IsForceBigDecimals, IsEnableSubPackages, IsTrimStrings, TableNames, Src);
            fileBuilder.GenerateMyBatisConfigXml();

            fileBuilder.run(Application.StartupPath + @"\gener.bat");
        }
    }

    class ConfigFileBuilder
    {

        //////////////// Static Fields  /////////////////
        static string TargetRuntime          = null;
        static string ConnectionUrl          = null;
        static string UserId                 = null;
        static string Password               = null;
        static string ModelPackage           = null;
        static string JavaMapperPackage      = null;
        static string XmlMapperPackage       = null;
        static string TableNames             = null;
        static string Src                    = null;
        static bool   IsForceBigDecimals     = false;
        static bool   IsEnableSubPackages    = false;
        static bool   IsTrimStrings          = false;

        /// <summary>
        /// Singleton instance
        /// </summary>
        private ConfigFileBuilder() { }

        /// <summary>
        /// Singleton instance object (global only one)
        /// </summary>
        private static ConfigFileBuilder instance = null;


        /// <summary>
        /// Get ConfigFileBuilder singleton instance
        /// </summary>
        /// <param name="TargetRuntime">targetRuntime. e.g : MyBatis3</param>
        /// <param name="ConnectionUrl">connectionUrl. e.g : jdbc:mysql://localhost:3306/wms?characterEncoding=utf-8</param>
        /// <param name="UserId">userId</param>
        /// <param name="Password">password</param>
        /// <param name="IsForceBigDecimals">isForceBigDecimals</param>
        /// <param name="IsEnableSubPackages">isEnableSubPackages</param>
        /// <param name="IsTrimStrings">isTrimStrings</param>
        /// <param name="ModelPackage">modelPackage</param>
        /// <param name="JavaMapperPackage">javaMapperPackage</param>
        /// <param name="XmlMapperPackage">xmlMapperPackage</param>
        /// <param name="TableNames">TableNames</param>
        /// <param name="Src">Src</param>
        /// <returns>ConfigFileBuilder singleton instance</returns>
        public static ConfigFileBuilder getInstance(string TargetRuntime, string ConnectionUrl, string UserId,
                                                    string Password, string ModelPackage, string JavaMapperPackage,
                                                    string XmlMapperPackage, bool IsForceBigDecimals, bool IsEnableSubPackages,
                                                    bool IsTrimStrings, string TableNames, string Src)
        {
            if (instance == null)
            {
                instance = new ConfigFileBuilder();

                ConfigFileBuilder.TargetRuntime = TargetRuntime;
                ConfigFileBuilder.ConnectionUrl = ConnectionUrl;
                ConfigFileBuilder.UserId = UserId;
                ConfigFileBuilder.Password = Password;
                ConfigFileBuilder.IsForceBigDecimals = IsForceBigDecimals;
                ConfigFileBuilder.IsEnableSubPackages = IsEnableSubPackages;
                ConfigFileBuilder.IsTrimStrings = IsTrimStrings;
                ConfigFileBuilder.ModelPackage = ModelPackage;
                ConfigFileBuilder.JavaMapperPackage = JavaMapperPackage;
                ConfigFileBuilder.XmlMapperPackage = XmlMapperPackage;
                ConfigFileBuilder.TableNames = TableNames;
                ConfigFileBuilder.Src = Src;
            }
            return instance;
        }

        const string DRIVER_JAR_FILE = "mysql-connector-java-5.1.25.jar";

        
        /// <summary>
        /// Generate Mybatis config file(xml) and write the application path
        /// </summary>
        public void GenerateMyBatisConfigXml()
        {
            string templateConfXml = GenerateMyBatisXmlStr();

            // TODO rewrite to conf.xml

            FileStream f = null;
            StreamWriter write = null;
            try
            {
                string execPath = Application.StartupPath;
                
                f = new FileStream(execPath + @"\conf.xml", FileMode.Create);
                write = new StreamWriter(f);
                write.WriteLine(templateConfXml);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                write.Close();
                f.Close();
            }
        }

        public void run(string batPath)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.CreateNoWindow = false;
                process.StartInfo.FileName = batPath;
                process.Start();
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Generate the mybatis config string (format:xml)
        /// </summary>
        /// <returns>the mybatis generate's core conf xml string</returns>
        public string GenerateMyBatisXmlStr()
        {
            string templateXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>  \n" +
            "<!DOCTYPE generatorConfiguration  \n" +
            "  PUBLIC \"-//mybatis.org//DTD MyBatis Generator Configuration 1.0//EN\"  \n" +
            "  \"http://mybatis.org/dtd/mybatis-generator-config_1_0.dtd\">\n" +
            "<generatorConfiguration>\n" +
            "\t<classPathEntry location=\"" + ConfigFileBuilder.DRIVER_JAR_FILE + "\" />\n" +
            "\t<context id=\"DB2Tables\" targetRuntime=\"" + ConfigFileBuilder.TargetRuntime + "\" defaultModelType=\"flat\">\n" +
            "\t\t<commentGenerator>\n" +
            "\t\t\t<property name=\"suppressAllComments\" value=\"true\" />\n" +
            "\t\t</commentGenerator>\n" +
            "\t\t<jdbcConnection driverClass=\"" + MySqlConnector.DRIVER_CLASS + "\"\n" +
            "\t\t\tconnectionURL=\"" + ConfigFileBuilder.ConnectionUrl + "\" userId=\"" + ConfigFileBuilder.UserId + "\"\n" +
            "\t\t\tpassword=\"" + ConfigFileBuilder.Password + "\">\n" +
            "\t\t</jdbcConnection>\n" +
            "\t\t<javaTypeResolver>\n" +
            "\t\t\t<property name=\"forceBigDecimals\" value=\""+ ConfigFileBuilder.IsForceBigDecimals.ToString().ToLower() + "\" />\n" +
            "\t\t</javaTypeResolver>\n" +
            "\t\t<javaModelGenerator targetPackage=\"" + ConfigFileBuilder.ModelPackage + "\"\n" +
            "\t\t\ttargetProject=\""+ ConfigFileBuilder.Src + "\">\n" +
            "\t\t\t<property name=\"enableSubPackages\" value=\"" + ConfigFileBuilder.IsEnableSubPackages.ToString().ToLower() + "\" />\n" +
            "\t\t\t<property name=\"trimStrings\" value=\"" + ConfigFileBuilder.IsTrimStrings.ToString().ToLower() + "\" />\n" +
            "\t\t</javaModelGenerator>\n" +
            "\t\t<sqlMapGenerator targetPackage=\"" + ConfigFileBuilder.JavaMapperPackage + "\"\n" +
            "\t\t\ttargetProject=\""+ ConfigFileBuilder.Src + "\">\n" +
            "\t\t\t<property name=\"enableSubPackages\" value=\"" + ConfigFileBuilder.IsEnableSubPackages.ToString().ToLower() + "\" />\n" +
            "\t\t</sqlMapGenerator>\n" +
            "\t\t<javaClientGenerator type=\"XMLMAPPER\"\n" +
            "\t\t\ttargetPackage=\"" + ConfigFileBuilder.XmlMapperPackage + "\" targetProject=\""+ ConfigFileBuilder.Src + "\">\n" +
            "\t\t\t<property name=\"enableSubPackages\" value=\"" + ConfigFileBuilder.IsEnableSubPackages.ToString().ToLower() + "\" />\n" +
            "\t\t</javaClientGenerator>\n" +
            "\t\t<table tableName=\""+ ConfigFileBuilder.TableNames +"\" schema=\"dbo\"   enableCountByExample=\"false\"\n" +
            "\t\t\tenableUpdateByExample=\"false\" enableDeleteByExample=\"false\"\n" +
            "\t\t\tenableSelectByExample=\"false\" selectByExampleQueryId=\"false\">\n" +
            "\t\t\t<property name=\"useActualColumnNames\" value=\"false\" />\n" +
            "\t\t</table>\n" +
            "\t</context>\n" +
            "</generatorConfiguration>  ";

            return templateXml;
        }
    }
}
