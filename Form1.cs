namespace BinarySearchTree
{
    public partial class Form1 : Form
    {
        private TreeNode root; // kök düðümü

        public Form1()
        {
            InitializeComponent();
            root = null;
        }

        public class TreeNode
        {
            public int Data { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }

            public TreeNode(int data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }

        private void btnEkleme_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEkleme.Text))
            {
                MessageBox.Show("Lütfen bir deðer girin.");
                return;
            }

            int valueToAdd;
            if (!int.TryParse(textBoxEkleme.Text, out valueToAdd))
            {
                MessageBox.Show("Geçersiz bir sayý giriþi yaptýnýz.");
                return;
            }

            root = Ekle(root, valueToAdd, this.ClientSize.Width / 2, 50);
            YazdirInOrder(root, this.ClientSize.Width / 2, 50);
        }


        private TreeNode Ekle(TreeNode root, int value, int x, int y)
        {
            if (root == null)
            {
                return new TreeNode(value);
            }
            else if (value < root.Data)
            {
                root.Left = Ekle(root.Left, value, x - 100, y + 50);
            }
            else if (value > root.Data)
            {
                root.Right = Ekle(root.Right, value, x + 100, y + 50);
            }
            else
            {
                MessageBox.Show("Sayý zaten mevcut.");
            }

            return root;
        }


        private void OlusturVeYerlestir(TreeNode node, int x, int y)
        {
            if (node != null)
            {
                Label dinamikLabel = new Label();
                dinamikLabel.Text = node.Data.ToString();
                dinamikLabel.Name = node.Data.ToString();
                dinamikLabel.Top = y;
                dinamikLabel.Left = x - dinamikLabel.Width / 2;

                this.Controls.Add(dinamikLabel);

                OlusturVeYerlestir(node.Left, x - 100, y + 50);
                OlusturVeYerlestir(node.Right, x + 100, y + 50);
            }
        }


        private void YazdirInOrder(TreeNode root, int x, int y)
        {
            textBoxEkleme.Clear();
            YazdirInOrderRecursive(root, x, y);
        }


        private void YazdirInOrderRecursive(TreeNode root, int x, int y)
        {
            if (root != null)
            {
                YazdirInOrderRecursive(root.Left, x - 100, y + 50);
                OlusturVeYerlestir(root, x, y);
                YazdirInOrderRecursive(root.Right, x + 100, y + 50);
            }
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxArama.Text))
            {
                MessageBox.Show("Lütfen bir deðer girin.");
                return;
            }

            int arananDeger;
            if (!int.TryParse(textBoxArama.Text, out arananDeger))
            {
                MessageBox.Show("Geçersiz bir sayý giriþi yaptýnýz.");
                return;
            }

            TreeNode foundNode = Arama(root, arananDeger);

            if (foundNode != null)
            {
                MessageBox.Show($"{arananDeger} bulundu.");
            }
            else
            {
                MessageBox.Show($"{arananDeger} bulunamadý.");
            }
        }

        private TreeNode Arama(TreeNode node, int arananDeger)
        {
            if (node == null)
            {
                return null; // Düðüm yoksa, hedef deðer aðaçta bulunamaz.
            }

            // Ýlgili düðümün rengini deðiþtir (kýrmýzýya)
            LabelRenkDegistir(node, Color.Red);


            if (arananDeger == node.Data)
            {
                return node; // Hedef deðeri bulduk.
            }
            else if (arananDeger < node.Data)
            {
                return Arama(node.Left, arananDeger);
            }
            else
            {
                return Arama(node.Right, arananDeger);
            }
        }

        private void LabelRenkDegistir(TreeNode node, Color color)
        {
            // TreeNode içerisindeki Label kontrolüne eriþim
            Control[] controls = this.Controls.Find(node.Data.ToString(), true);

            if (controls.Length > 0 && controls[0] is Label)
            {
                Label label = (Label)controls[0];
                label.BackColor = color;
            }
        }

        private void btnMinBul_Click(object sender, EventArgs e)
        {
            TreeNode minNode = MinimumBul(root);

            if (minNode != null)
            {
                textBoxMinBul.Text = minNode.Data.ToString();
                MessageBox.Show($"Minimum deðer bulundu: {minNode.Data}");
            }
            else
            {
                MessageBox.Show("Aðaç boþ.");
            }

        }

        private TreeNode MinimumBul(TreeNode node)
        {
            TreeNode current = node;

            // En sol düðüme git, çünkü minimum deðer en sol düðümde bulunur.
            while (current.Left != null)
            {
                current = current.Left;
            }

            return current;
        }

        private void btnMaxBul_Click(object sender, EventArgs e)
        {
            TreeNode minNode = MaksimumBul(root);

            if (minNode != null)
            {
                textBoxMaxBul.Text = minNode.Data.ToString();
                MessageBox.Show($"Maksimum deðer bulundu: {minNode.Data}");
            }
            else
            {
                MessageBox.Show("Aðaç boþ.");
            }
        }

        private TreeNode MaksimumBul(TreeNode node)
        {
            TreeNode current = node;

            // En sol düðüme git, çünkü minimum deðer en sol düðümde bulunur.
            while (current.Right != null)
            {
                current = current.Right;
            }

            return current;
        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            if (root != null)
            {
                textBoxDolasmaSonucu.Text = PreOrder(root);
            }
            else
            {
                MessageBox.Show("Aðaç boþ.");
            }
        }

        private string PreOrder(TreeNode node)
        {
            if (node == null)
            {
                return "";
            }

            // Gezilen düðümün deðerini al
            string sonuc = node.Data + " ";

            // Sol alt aðaca git
            sonuc += PreOrder(node.Left);

            // Sað alt aðaca git
            sonuc += PreOrder(node.Right);

            return sonuc;
        }

        private void btnInOrder_Click(object sender, EventArgs e)
        {
            if (root != null)
            {
                textBoxDolasmaSonucu.Text = InOrder(root);
            }
            else
            {
                MessageBox.Show("Aðaç boþ.");
            }
        }

        private string InOrder(TreeNode node)
        {
            if (node == null)
            {
                return "";
            }

            // Sol alt aðaca git
            string sonuc = InOrder(node.Left);

            // Gezilen düðümün deðerini al
            sonuc += node.Data + " ";

            // Sað alt aðaca git
            sonuc += InOrder(node.Right);

            return sonuc;
        }

        private void btnPostOrder_Click(object sender, EventArgs e)
        {
            if (root != null)
            {
                textBoxDolasmaSonucu.Text = PostOrder(root);
            }
            else
            {
                MessageBox.Show("Aðaç boþ.");
            }
        }

        private string PostOrder(TreeNode node)
        {
            if (node == null)
            {
                return "";
            }

            // Sol alt aðaca git
            string sonuc = PostOrder(node.Left);

            // Sað alt aðaca git
            sonuc += PostOrder(node.Right);

            // Gezilen düðümün deðerini al
            sonuc += node.Data + " ";

            return sonuc;
        }
    }
}
