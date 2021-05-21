using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using WareHouse.AppResources;
using WareHouse.Entities;
using WareHouse.Enums;
using WareHouse.Exceptions;
using WareHouse.Helpers;
using WareHouse.Managers;
using WareHouse.Properties;

namespace WareHouse.Forms
{
    public partial class Main : Form
    {
        /// <summary>
        /// Filter for search products in gridView.
        /// </summary>
        private string _filter;


        public Main()
        {
            InitializeComponent();

            GridView.Rows.CollectionChanged += RowsCollectionChanged;

            FormDock.SubscribeControlsToDragEvents(
                new Control[] {ToolPanel, ToolCards, WorkCards, ToolTableLayoutPanel, GridPanel});

            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;

            _filter = string.Empty;
        }

        #region Form manage

        /// <summary>
        /// Load data and set some settings.
        /// </summary>
        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                Manager.LoadWarehouse();
                AppLoad();
                NodeCollectionChanged();
                SetLocalization();
            }
            catch
            {
                // ignored
            }
        }


        /// <summary>
        /// Set localizable data.
        /// </summary>
        private void SetLocalization()
        {
            AddRootButton.Text = ApplicationStrings.AddRootText;
            AddSectionButton.Text = ApplicationStrings.AddSectionText;
            AddProductButton.Text = ApplicationStrings.AddProductText;
            SearchTextBox.PlaceholderText = ApplicationStrings.SearchPlaceholder;
            SearchTextBox.TextPlaceholder = ApplicationStrings.SearchPlaceholder;
            GenerateButton.Text = ApplicationStrings.GenerateButtonText;
            QuantityButton.Text = ApplicationStrings.QuantityButtonText;
            PriceButton.Text = ApplicationStrings.PriceButtonText;
            ShowOrdersButton.Text = ApplicationStrings.ShowOrdersButtonText;
            
            ToolTip.SetToolTip(AddRootButton, ApplicationStrings.AddRootButtonToolTip);
            ToolTip.SetToolTipTitle(AddRootButton, ApplicationStrings.AddRootButtonToolTipTitle); 

            ToolTip.SetToolTip(AddSectionButton, ApplicationStrings.AddSectionButtonToolTip);
            ToolTip.SetToolTipTitle(AddSectionButton, ApplicationStrings.AddSectionButtonToolTipTitle);

            ToolTip.SetToolTip(AddProductButton, ApplicationStrings.AddProductButtonToolTip);
            ToolTip.SetToolTipTitle(AddProductButton,ApplicationStrings.AddProductButtonToolTipTitle);

            ToolTip.SetToolTip(ExportCsvButton, ApplicationStrings.ExportCsvButtonToolTip);
            ToolTip.SetToolTipTitle(ExportCsvButton, ApplicationStrings.ExportCsvButtonToolTipTitle);

            ToolTip.SetToolTip(GenerateButton, ApplicationStrings.GenerateButtonToolTip);
            ToolTip.SetToolTipTitle(GenerateButton, ApplicationStrings.GenerateButtonToolTipTitle);

            ToolTip.SetToolTip(QuantityButton, ApplicationStrings.QuantityButtonToolTip);
            ToolTip.SetToolTipTitle(QuantityButton, ApplicationStrings.QuantityButtonToolTipTitle);

            ToolTip.SetToolTip(PriceButton, ApplicationStrings.PriceButtonToolTip);
            ToolTip.SetToolTipTitle(PriceButton, ApplicationStrings.PriceButtonToolTipTitle);

            ToolTip.SetToolTip(EngButton, ApplicationStrings.EngButtonToolTip);
            ToolTip.SetToolTipTitle(EngButton, ApplicationStrings.EngButtonToolTipTitle);

            ToolTip.SetToolTip(RusButton, ApplicationStrings.RusButtonToolTip);
            ToolTip.SetToolTipTitle(RusButton,ApplicationStrings.RusButtonToolTipTitle);

            ToolTip.SetToolTip(SearchTextBox, ApplicationStrings.SearchTextBoxToolTip);
            ToolTip.SetToolTipTitle(SearchTextBox, ApplicationStrings.SearchTextBoxToolTipTitle);

            ToolTip.SetToolTip(ShowOrdersButton, ApplicationStrings.ShowOrdersButtonToolTip);
            ToolTip.SetToolTipTitle(ShowOrdersButton, ApplicationStrings.ShowOrdersButtonToolTipTitle);

            ToolTip.SetToolTip(ChangeAccBox, ApplicationStrings.ChangeAccBoxToolTip);
            ToolTip.SetToolTipTitle(ChangeAccBox,ApplicationStrings.ChangeAccBoxToolTipTitle);
        }

        /// <summary>
        /// Create nodes from load data.
        /// </summary>
        private void AppLoad()
        {
            // Get sections and sort by path length.
            var tempSections = SectionManager.GetSections();
            tempSections.Sort((a, b) => a.Path.Count.CompareTo(b.Path.Count));

            // Create roots.
            foreach (var section in tempSections.Where(x => x.Path.Count == 1))
            {
                ProductTreeView.Nodes.Add(new CustomNode(section.Name, section.Path) {Text = section.Name});
            }

            // Create child sections.
            foreach (var section in tempSections.Where(x => x.Path.Count > 1))
            {
                var parentNode = NodeHelper.ToList(ProductTreeView.Nodes).OfType<CustomNode>().First(x =>
                    x.Path.Count + 1 == section.Path.Count &&
                    SectionManager.Get(x.SectionName, x.Path).IsSubSection(section));
                parentNode.Nodes.Add(new CustomNode(section.Name, section.Path) {Text = section.Name});
            }

            // Set settings and sort nodes.
            EditToolStripMenuItem.Visible = GridView.RowCount > 0;
            DeleteProductToolStripMenuItem.Visible = GridView.RowCount > 0;
            ExportCsvButton.Enabled = ProductManager.GetProducts().Any();

            ProductTreeView.TreeViewNodeSorter = new NodeQuantitySorter();
            ProductTreeView.Sort();
        }

        /// <summary>
        /// Set english language.
        /// </summary>
        private void EngButton_Click(object sender, EventArgs e)
        {
            // Set english language.
            Save("culture", "en-US");
            Application.Restart();
            NodeCollectionChanged();
        }

        /// <summary>
        /// Set russian language.
        /// </summary>
        private void RusButton_Click(object sender, EventArgs e)
        {
            Save("culture", "ru-RU");
            Application.Restart();
            NodeCollectionChanged();
        }


        /// <summary>
        /// Save locale settings.
        /// </summary>
        /// <param name="key">Key in config.</param>
        /// <param name="value">New value.</param>
        private static void Save(string key, string value)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = config.AppSettings.Settings;
            if (settings[key] != null)
                settings.Remove(key);
            settings.Add(key, value);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }

        /// <summary>
        /// Save data in time.
        /// </summary>
        private void SaveTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                Manager.SaveWarehouse();
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// Save data while closing form.
        /// </summary>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Manager.SaveWarehouse();
            }
            catch
            {
                // ignored
            }
        }


        /// <summary>
        /// Change user account.
        /// </summary>
        private void ChangeAccBox_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        #endregion


        #region Panel buttons

        /// <summary>
        /// Close form.
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Roll form.
        /// </summary>
        private void RollButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Hide form.
        /// </summary>
        private void HideButton_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        /// <summary>
        /// Change form size.
        /// </summary>
        private void ToolPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        /// <summary>
        /// Change form size.
        /// </summary>
        private void ToolPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        #endregion


        #region Manage products

        /// <summary>
        /// Create new product.
        /// </summary>
        private void AddProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        /// <summary>
        /// Create new product.
        /// </summary>
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        /// <summary>
        /// Create new product.
        /// </summary>
        private void AddProduct()
        {
            while (true)
            {
                try
                {
                    // Get parent node and section.
                    var node = (CustomNode) ProductTreeView.SelectedNode;
                    var parentSection =
                        SectionManager.Get(node.SectionName, node.Path);

                    using (var productCreator = new ProductCreatorForm())
                    {
                        if (productCreator.ShowDialog() != DialogResult.OK) return;

                        // Copy data.
                        var tempProduct = (Product) productCreator.Product.Clone();
                        tempProduct.Path = parentSection.Path;
                        // Add new product to collection.
                        ProductManager.Add(tempProduct);
                    }

                    // Set settings.
                    NodeCollectionChanged();

                    SetGridViewData((CustomNode) ProductTreeView.SelectedNode);
                    ExportCsvButton.Enabled = ProductManager.GetProducts().Any();


                    break;
                }
                catch (Exception exception)
                {
                    if (MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage,
                        MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Error) != DialogResult.Retry)
                    {
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Edit product data.
        /// </summary>
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridView.SelectedRows.Count == 0) return;

                // Get product by name and path.
                var name = GridView.SelectedRows[0].Cells["ProductName"].Value.ToString();
                var path = GridView.SelectedRows[0].Cells["ProductPath"].Value as List<string>;
                var product = ProductManager.Get(name, path);

                using (var productEditor = new ProductCreatorForm(product))
                {
                    if (productEditor.ShowDialog() != DialogResult.OK) return;
                    // Change and copy data.
                    productEditor.Product.Path = path;

                    product.Clone(productEditor.Product);
                }

                // Set settings.
                SetGridViewData((CustomNode) ProductTreeView.SelectedNode);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Remove certain product.
        /// </summary>
        private void DeleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridView.SelectedRows.Count == 0) return;

                // Get product by name and path.
                var name = GridView.SelectedRows[0].Cells["ProductName"].Value.ToString();
                var path = GridView.SelectedRows[0].Cells["ProductPath"].Value as List<string>;
                var product = ProductManager.Get(name, path);

                // Warning message.
                if (MessageBox.Show(ApplicationStrings.WarningMessageText, ApplicationStrings.MessageWarning,
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) !=
                    DialogResult.OK) return;

                // Remove product from collection.
                ProductManager.Remove(product);

                // Set settings.
                SetGridViewData((CustomNode) ProductTreeView.SelectedNode);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion


        #region Manage grid view

        /// <summary>
        /// Change grid view scroll position.
        /// </summary>
        private void GridVScrollBar_Scroll(object sender, BunifuVScrollBar.ScrollEventArgs e)
        {
            try
            {
                GridView.FirstDisplayedScrollingRowIndex = GridView.Rows[e.Value].Index;
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// Change scroll data and gridView settings.
        /// </summary>
        private void RowsCollectionChanged(object sender, CollectionChangeEventArgs e)
        {
            try
            {
                GridVScrollBar.Maximum = GridView.RowCount;
            }
            catch
            {
                // ignored
            }
            finally
            {
                EditToolStripMenuItem.Visible = GridView.RowCount > 0;
                DeleteProductToolStripMenuItem.Visible = GridView.RowCount > 0;
            }
        }

        /// <summary>
        /// Change data in gridView by filter.
        /// </summary>
        private void SearchTextBox_TextChange(object sender, EventArgs e)
        {
            try
            {
                _filter = SearchTextBox.Text.Trim();
                if (ProductTreeView.SelectedNode != null)
                {
                    SetGridViewData((CustomNode) ProductTreeView.SelectedNode);
                }
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// Change data in grid view.
        /// </summary>
        /// <param name="node">Certain node.</param>
        private void SetGridViewData(CustomNode node)
        {
            // Get parent section.
            var parentSection = SectionManager.Get(node.SectionName, node.Path);

            GridView.Rows.Clear();

            // Get products which contains filter name.
            foreach (var product in parentSection.GetProducts()
                .Where(x => x.Name.ToLower().Contains(_filter.ToLower())))
            {
                try
                {
                    // Add new row.
                    GridView.Rows.Add(
                        Resources.round_green, product.Name, product.Code,
                        product.Quantity, $"{product.Price} {product.Currency}",
                        $"{product.Discount} %", product.UCN,
                        Countries.GetCountry(product.Country),
                        product.Guarantee, product.Status, product.Path);
                }
                catch
                {
                    // ignored
                }
            }

            // Add new rows from child section.
            foreach (var product in parentSection.GetSections().SelectMany(section =>
                section.GetProducts()).Where(x => x.Name.ToLower().Contains(_filter.ToLower())))
            {
                try
                {
                    GridView.Rows.Add(
                        Resources.round_blue, product.Name, product.Code,
                        product.Quantity, $"{product.Price} {product.Currency}",
                        $"{product.Discount} %", product.UCN,
                        Countries.GetCountry(product.Country),
                        product.Guarantee, product.Status, product.Path);
                }
                catch
                {
                    // ignored
                }
            }
        }

        #endregion


        #region Manage roots

        /// <summary>
        /// Add new root.
        /// </summary>
        private void AddRootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRoot();
        }

        /// <summary>
        /// Add new root.
        /// </summary>
        private void AddRootButton_Click(object sender, EventArgs e)
        {
            AddRoot();
        }

        /// <summary>
        /// Add new root.
        /// </summary>
        private void AddRoot()
        {
            try
            {
                using (var rootCreator = new RootCreatorForm())
                {
                    if (rootCreator.ShowDialog() != DialogResult.OK) return;

                    // Create new root and add to collection.
                    var tempSection = new Section(rootCreator.Section.Name);

                    SectionManager.Add(tempSection);
                    ProductTreeView.Nodes.Add(new CustomNode(tempSection.Name, tempSection.Path));
                }

                NodeCollectionChanged();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion


        #region Manage sections

        /// <summary>
        /// Add new section.
        /// </summary>
        private void AddSectionButton_Click(object sender, EventArgs e)
        {
            AddSection();
        }

        /// <summary>
        /// Add new section.
        /// </summary>
        private void AddSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSection();
        }

        /// <summary>
        /// Add new section.
        /// </summary>
        private void AddSection()
        {
            while (true)
            {
                try
                {
                    // Get parent node and section.
                    var node = (CustomNode) ProductTreeView.SelectedNode;
                    var parentSection = SectionManager.Get(node.SectionName, node.Path);


                    using (var rootCreator = new RootCreatorForm(parentSection.Path.Clone().ToList()))
                    {
                        if (rootCreator.ShowDialog() != DialogResult.OK) return;

                        // Create new section and add to collection.
                        var tempSection = new Section(rootCreator.Section.Name, parentSection.Path.ToList());
                        SectionManager.Add(tempSection);

                        parentSection.Sections.Add(tempSection.Name);

                        node.Nodes.Add(new CustomNode(tempSection.Name, tempSection.Path));
                    }

                    NodeCollectionChanged();

                    break;
                }
                catch (Exception exception)
                {
                    if (MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage,
                        MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Error) != DialogResult.Retry)
                    {
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Rename certain section.
        /// </summary>
        private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Get certain section and node.
                var tempNode = (CustomNode) ProductTreeView.SelectedNode;
                var tempNodes = NodeHelper.ToList(tempNode.Nodes).OfType<CustomNode>().ToList();
                var tempSection = SectionManager.Get(tempNode.SectionName, tempNode.Path);

                using (var rootCreator = new RootCreatorForm(tempSection))
                {
                    while (true)
                    {
                        try
                        {
                            if (rootCreator.ShowDialog() != DialogResult.OK) break;

                            if (SectionManager.SectionExists(tempSection, rootCreator.Section.Name))
                            {
                                throw new CustomDataException(ApplicationStrings.SectionExistException, 400);
                            }

                            // Change section name.
                            tempSection.Rename(rootCreator.Section.Name);

                            tempNode.SectionName = rootCreator.Section.Name;
                            tempNode.Text = tempNode.SectionName;
                            var path = rootCreator.Section.Path;
                            // Change path in child sections.
                            foreach (var node in tempNodes)
                            {
                                for (var i = 0; i < path.Count; i++)
                                {
                                    node.Path[i] = path[i];
                                }
                            }

                            break;
                        }
                        catch (Exception exception)
                        {
                            if (MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage,
                                MessageBoxButtons.RetryCancel,
                                MessageBoxIcon.Error) != DialogResult.Retry)
                            {
                                break;
                            }
                        }
                    }
                }
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// Delete certain section.
        /// </summary>
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Get certain section.
                var node = (CustomNode) ProductTreeView.SelectedNode;
                var section = SectionManager.Get(node.SectionName, node.Path);

                // Warning message.
                if (MessageBox.Show(ApplicationStrings.WarningMessageText, ApplicationStrings.MessageWarning,
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) !=
                    DialogResult.OK) return;

                // Remove section and node from collections.
                ProductTreeView.Nodes.Remove(node);
                SectionManager.Remove(section);

                NodeCollectionChanged();

                GridView.Rows.Clear();
                ExportCsvButton.Enabled = ProductManager.GetProducts().Any();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion


        #region Manage tree view

        /// <summary>
        /// Set data to gridView when click to node.
        /// </summary>
        private void ProductTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                // Get node.
                var node = (CustomNode) e.Node;
                ProductTreeView.SelectedNode = node;
                NodeCollectionChanged();
                // Set data.
                SetGridViewData(node);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Set visible and enabled settings to some controls.
        /// </summary>
        private void NodeCollectionChanged()
        {
            if (ProductTreeView.Nodes.Count > 0 && ProductTreeView.SelectedNode != null)
            {
                AddSectionButton.Enabled = true;
                AddProductButton.Enabled = true;
                AddSectionToolStripMenuItem.Visible = true;
                AddProductToolStripMenuItem.Visible = true;
                RenameToolStripMenuItem.Visible = true;
                DeleteToolStripMenuItem.Visible = true;
            }
            else
            {
                AddSectionButton.Enabled = false;
                AddProductButton.Enabled = false;
                AddSectionToolStripMenuItem.Visible = false;
                AddProductToolStripMenuItem.Visible = false;
                RenameToolStripMenuItem.Visible = false;
                DeleteToolStripMenuItem.Visible = false;
            }
        }

        /// <summary>
        /// Sort nodes by total products quantity.
        /// </summary>
        private void QuantityButton_Click(object sender, EventArgs e)
        {
            try
            {
                ProductTreeView.TreeViewNodeSorter = new NodeQuantitySorter();
                ProductTreeView.Sort();
                GridView.Rows.Clear();
                NodeCollectionChanged();
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// Sort nodes by total products price.
        /// </summary>
        private void PriceButton_Click(object sender, EventArgs e)
        {
            try
            {
                ProductTreeView.TreeViewNodeSorter = new NodePriceSorter();
                ProductTreeView.Sort();
                GridView.Rows.Clear();
                NodeCollectionChanged();
            }
            catch
            {
                // ignored
            }
        }

        #endregion


        #region Report

        /// <summary>
        /// Create CSV report.
        /// </summary>
        private void ExportCsvButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var csvCreator = new CsvCreator())
                {
                    if (csvCreator.ShowDialog() != DialogResult.OK) return;

                    using (var saveDialog = new SaveFileDialog {Filter = ApplicationStrings.SaveFileFilter})
                    {
                        if (saveDialog.ShowDialog() != DialogResult.OK) return;

                        using (var fileStream = new FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write))
                        {
                            using (var streamWriter = new StreamWriter(fileStream))
                            {
                                // Get products which quantity less than minimum quantity or equals.
                                var products = ProductManager.GetProducts().Where(product =>
                                    product.Quantity <= csvCreator.MinimumQuantity);

                                // Create report strings.
                                var csvString = new StringBuilder();
                                csvString.AppendLine("Path;Code;Name;Quantity");

                                // Internal function allow to separate list data. 
                                string ListToString(IReadOnlyList<string> list)
                                {
                                    var str = string.Empty;
                                    for (var i = 0; i < list.Count; i++)
                                    {
                                        str += list[i] + (i + 1 == list.Count ? "" : "\\");
                                    }

                                    return str;
                                }

                                // Set data.
                                foreach (var product in products)
                                {
                                    // Add new string to report.
                                    var str =
                                        $"{ListToString(product.Path)};{product.Code};{product.Name};{product.Quantity}";
                                    csvString.AppendLine(str);
                                }

                                // Save report.
                                streamWriter.Write(csvString);
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Show all orders.
        /// </summary>
        private void ShowOrdersButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var orders = new OrderManageForm())
                {
                    orders.ShowDialog();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion


        #region Generate sections

        /// <summary>
        /// Generate roots, sections and products.
        /// </summary>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Generate();
                ExportCsvButton.Enabled = ProductManager.GetProducts().Any();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ApplicationStrings.ErorrMessage, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Generate roots, sections and products.
        /// </summary>
        private void Generate()
        {
            using (var generate = new GenerateForm())
            {
                if (generate.ShowDialog() != DialogResult.OK) return;

                var sections = new List<Section>();
                // Generate company.
                GenerateCompany();
                // Generate roots.
                GenerateSections(sections, generate.RootQuantity, "NewRoot");
                // Generate products.
                GenerateProducts(generate.ProductQuantity, sections);

                // Recursion creating.
                foreach (var section in sections)
                {
                    GenerateInternal(section, generate.SectionQuantity, generate.ProductQuantity,
                        generate.RecursionDepth);
                }
            }
        }

        /// <summary>
        /// Generate company if there are not any company.
        /// </summary>
        private static void GenerateCompany()
        {
            if (CompanyManager.GetNames().Any()) return;

            // Create new company and add it.
            var newCompany = new Company
            {
                Name = "Company",
                Address = "Address",
                Chief = "Chief",
                Description = "New company",
                PhoneNumber = "000-000-000-000",
                Photo = ImgConverter.ConvertImgToString(Resources.Company___default)
            };
            CompanyManager.Add(newCompany);
        }

        /// <summary>
        /// Internal method to create child sections by recursion.
        /// </summary>
        /// <param name="parentSection">Parent section.</param>
        /// <param name="sectionQuantity">Section quantity.</param>
        /// <param name="productQuantity">Product quantity.</param>
        /// <param name="recursionDepth">Recursion depth.</param>
        private void GenerateInternal(Section parentSection, int sectionQuantity, int productQuantity,
            int recursionDepth)
        {
            var sections = new List<Section>();

            // Generate child sections.
            GenerateSections(sections, sectionQuantity, "NewSection", parentSection);

            // Generate products for it and child sections.
            GenerateProducts(productQuantity, sections);
            if (recursionDepth <= 0) return;

            foreach (var section in sections)
            {
                GenerateInternal(section, sectionQuantity, productQuantity, recursionDepth - 1);
            }
        }

        /// <summary>
        /// Generate child sections.
        /// </summary>
        /// <param name="sections">Child sections.</param>
        /// <param name="sectionQuantity">Section quantity.</param>
        /// <param name="name">Sections name.</param>
        /// <param name="parentSection">Parent section.</param>
        private void GenerateSections(List<Section> sections, int sectionQuantity, string name,
            Section parentSection = null)
        {
            var sectionId = 1;
            CustomNode parentNode = null;
            // Get parent node.
            if (parentSection != null)
            {
                parentNode = NodeHelper.ToList(ProductTreeView.Nodes)
                    .OfType<CustomNode>().First(node =>
                        node.SectionName.Equals(parentSection.Name,
                            StringComparison.InvariantCultureIgnoreCase) &&
                        node.Path.SequenceEqual(parentSection.Path));
            }

            var tryCount = 0;
            for (var i = 0; i < sectionQuantity; i++)
            {
                try
                {
                    // Create section and add it to collection.
                    tryCount++;
                    var section = parentSection == null
                        ? new Section($"{name}{sectionId++}")
                        : new Section($"{name}{sectionId++}", parentSection.Path);
                    SectionManager.Add(section);
                    sections.Add(section);

                    // Add to treeView.
                    if (parentSection != null)
                    {
                        parentNode.Nodes.Add(new CustomNode(section.Name, section.Path));
                    }

                    else
                    {
                        ProductTreeView.Nodes.Add(new CustomNode(section.Name, section.Path));
                    }

                    tryCount = 0;
                }
                catch
                {
                    i--;
                    if (tryCount >= 10000) break;
                }
            }
        }

        /// <summary>
        /// Generate products.
        /// </summary>
        /// <param name="productQuantity">Product quantity.</param>
        /// <param name="sections">Child sections.</param>
        private static void GenerateProducts(int productQuantity, List<Section> sections)
        {
            foreach (var section in sections)
            {
                try
                {
                    GenerateProductsInternal(section, productQuantity);
                }
                catch
                {
                    // ignored
                }
            }
        }

        /// <summary>
        /// Generate product.
        /// </summary>
        /// <param name="parentSection">Parent section.</param>
        /// <param name="productQuantity">Product quantity.</param>
        private static void GenerateProductsInternal(Section parentSection, int productQuantity)
        {
            var productId = 1;
            var tryCount = 0;

            for (var i = 0; i < productQuantity; i++)
            {
                try
                {
                    tryCount++;
                    // Create product and add it to collection.
                    var product = new Product
                    {
                        Path = parentSection.Path,
                        Name = $"NewProduct{productId++}",
                        Company = CompanyManager.GetNames()[0],
                        Price = Manager.Random.Next(1, 10000),
                        Photo = ImgConverter.ConvertImgToString(Resources.Product_default),
                        Quantity = Manager.Random.Next(1, 100),
                        Description = "New product",
                        Code = "CODE",
                        UCN = "UCN",
                        Currency = (Currency) Manager.Random.Next(0, 5),
                        Guarantee = (Guarantee) Manager.Random.Next(0, 2),
                        Country = (Country) Manager.Random.Next(0, 196),
                        Discount = Manager.Random.Next(1, 50)
                    };

                    ProductManager.Add(product);

                    tryCount = 0;
                }
                catch
                {
                    i--;
                    if (tryCount >= 10000) break;
                }
            }
        }

        #endregion
    }
}