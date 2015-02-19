﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using LayoutFarm.Ease;
using LayoutFarm.WebDom;
using LayoutFarm.WebDom.Extension;

namespace Test5_Ease
{
    public partial class Form1 : Form
    {
        EaseViewport easeViewport;
        public Form1()
        {
            InitializeComponent();

            //1. create viewport
            easeViewport = EaseHost.CreateViewportControl(this, 800, 600);
            //2. add
            this.panel1.Controls.Add(easeViewport.ViewportControl);
            //this.Controls.Add(easeViewport.ViewportControl);
            this.Load += new EventHandler(Form1_Load);
        }
        void Form1_Load(object sender, EventArgs e)
        {
            //load sample html text
            easeViewport.Ready();
            string filename = @"..\..\..\HtmlRenderer.Demo\Samples\ClassicSamples\00.Intro.htm";
            //read text file
            var fileContent = System.IO.File.ReadAllText(filename);
            easeViewport.LoadHtml(filename, fileContent);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //test load html text 
            string filename = @"..\..\..\HtmlRenderer.Demo\Samples\ClassicSamples\00.Intro.htm";
            //read html text file
            var fileContent = "<html><body><div>Hello !</div><body><html>";
            easeViewport.LoadHtml(filename, fileContent);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filename = @"..\..\..\HtmlRenderer.Demo\Samples\ClassicSamples\00.Intro.htm";

            //1. blank html
            var fileContent = "<html><body><body><html>";
            easeViewport.LoadHtml(filename, fileContent);
            //2. access dom 

            WebDocument webdoc = easeViewport.GetHtmlDom();
            webdoc.RootNode.AddChild("div", div =>
            {
                div.AddChild("div", div_1 =>
                {
                    div_1.SetAttribute("style", "font:10pt tahoma");
                    div_1.AddChild("span", span =>
                    {
                        span.AddTextContent("test1");
                    });
                    div_1.AddChild("span", span =>
                    {
                        span.AddTextContent("test2");
                    });
                });
            });


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filename = @"..\..\..\HtmlRenderer.Demo\Samples\ClassicSamples\00.Intro.htm";

            //1. blank html
            var fileContent = "<html><body><div id=\"a\">A</div><div id=\"b\" style=\"background-color:blue\">B</div><body><html>";
            easeViewport.LoadHtml(filename, fileContent);
            //2. access dom  
            WebDocument webdoc = easeViewport.GetHtmlDom();
            //3. get element by id 
            var domNodeA = webdoc.GetElementById("a");
            var domNodeB = webdoc.GetElementById("b");

            domNodeA.AddTextContent("Hello from A");
            domNodeB.AddChild("div", div =>
            {
                div.SetAttribute("style", "background-color:yellow");
                div.AddTextContent("Hello from B");

            });
        }

    }
}
