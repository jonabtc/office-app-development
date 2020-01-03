using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ServiceReference1.GlobalWeatherSoapClient gw = new ServiceReference1.GlobalWeatherSoapClient("GlobalWeatherSoap");
        this.ResultadosTextBox.Text = gw.GetWeather(this.CiudadTextBox.Text, this.PaisTextBox.Text);

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ServiceReference1.GlobalWeatherSoapClient gw = new ServiceReference1.GlobalWeatherSoapClient("GlobalWeatherSoap");
        string xml = gw.GetWeather(this.CiudadTextBox.Text, this.PaisTextBox.Text);
                // We load the string in an xml reader to parse it 
        XmlReader reader = XmlReader.Create(new System.IO.StringReader(xml));
        reader.MoveToContent();
        // Parse the file and find the values
        string resultado = "";
        while (reader.Read())
        {
            switch (reader.NodeType)
            {
                case XmlNodeType.Element: // The node is an element.
                    resultado += reader.Name + ": ";
                    break;

                case XmlNodeType.Text: //Display the text in each element.
                    resultado += reader.Value + "\n";
                    break;

            }
        }
        reader.Close();
        this.ResultadosTextBox.Text = resultado;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string m_strFilePath = "http://api.openweathermap.org/data/2.5/weather?q=" + this.CiudadTextBox.Text + "&mode=xml";
        XmlTextReader reader = new XmlTextReader(m_strFilePath);
        string texto = "";
        while (reader.Read())
        {
            switch (reader.NodeType)
            {
                case XmlNodeType.Element: // The node is an element.
                    texto+=reader.Name + "\n";

                    while (reader.MoveToNextAttribute()) // Read the attributes.
                         texto+=" " + reader.Name + "='" + reader.Value + "'" + "\n";
                     
                    break;
                case XmlNodeType.Text: //Display the text in each element.
                     texto+=reader.Value + "\n";
                    break;
                
            }
        }

        this.ResultadosTextBox.Text = texto;
    }
}