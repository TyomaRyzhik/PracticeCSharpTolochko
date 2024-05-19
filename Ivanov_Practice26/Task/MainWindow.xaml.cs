﻿using Microsoft.Win32;
using System;
using System.Windows;
using System.Xml.Linq;

namespace Task
{
    public partial class MainWindow : Window
    {
        private XDocument libraryXml;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleTextBox.Text) || string.IsNullOrWhiteSpace(authorTextBox.Text) || string.IsNullOrWhiteSpace(yearTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            if (libraryXml == null)
            {
                libraryXml = new XDocument(new XElement("Библиотека"));
            }

            libraryXml.Root.Add(new XElement("Книга",
                new XElement("Название", titleTextBox.Text),
                new XElement("Автор", authorTextBox.Text),
                new XElement("ГодИздания", yearTextBox.Text)));

            booksListBox.Items.Add(titleTextBox.Text);

            titleTextBox.Clear();
            authorTextBox.Clear();
            yearTextBox.Clear();
        }

        private void LoadXml_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML files (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == true)
            {
                libraryXml = XDocument.Load(openFileDialog.FileName);
                booksListBox.Items.Clear();
                foreach (XElement book in libraryXml.Root.Elements("Книга"))
                {
                    booksListBox.Items.Add(book.Element("Название").Value);
                }
            }
        }

        private void SaveXml_Click(object sender, RoutedEventArgs e)
        {
            if (libraryXml != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                if (saveFileDialog.ShowDialog() == true)
                {
                    libraryXml.Save(saveFileDialog.FileName);
                }
            }
            else
            {
                MessageBox.Show("Нет данных для сохранения.");
            }
        }
    }
}
