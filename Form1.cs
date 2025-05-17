namespace BinarySearchTree
{
    public partial class Form1 : Form
    {
        private TreeNode root; // k�k d���m�

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
                MessageBox.Show("L�tfen bir de�er girin.");
                return;
            }

            int valueToAdd;
            if (!int.TryParse(textBoxEkleme.Text, out valueToAdd))
            {
                MessageBox.Show("Ge�ersiz bir say� giri�i yapt�n�z.");
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
                MessageBox.Show("Say� zaten mevcut.");
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
                MessageBox.Show("L�tfen bir de�er girin.");
                return;
            }

            int arananDeger;
            if (!int.TryParse(textBoxArama.Text, out arananDeger))
            {
                MessageBox.Show("Ge�ersiz bir say� giri�i yapt�n�z.");
                return;
            }

            TreeNode foundNode = Arama(root, arananDeger);

            if (foundNode != null)
            {
                MessageBox.Show($"{arananDeger} bulundu.");
            }
            else
            {
                MessageBox.Show($"{arananDeger} bulunamad�.");
            }
        }

        private TreeNode Arama(TreeNode node, int arananDeger)
        {
            if (node == null)
            {
                return null; // D���m yoksa, hedef de�er a�a�ta bulunamaz.
            }

            // �lgili d���m�n rengini de�i�tir (k�rm�z�ya)
            LabelRenkDegistir(node, Color.Red);


            if (arananDeger == node.Data)
            {
                return node; // Hedef de�eri bulduk.
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
            // TreeNode i�erisindeki Label kontrol�ne eri�im
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
                MessageBox.Show($"Minimum de�er bulundu: {minNode.Data}");
            }
            else
            {
                MessageBox.Show("A�a� bo�.");
            }

        }

        private TreeNode MinimumBul(TreeNode node)
        {
            TreeNode current = node;

            // En sol d���me git, ��nk� minimum de�er en sol d���mde bulunur.
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
                MessageBox.Show($"Maksimum de�er bulundu: {minNode.Data}");
            }
            else
            {
                MessageBox.Show("A�a� bo�.");
            }
        }

        private TreeNode MaksimumBul(TreeNode node)
        {
            TreeNode current = node;

            // En sol d���me git, ��nk� minimum de�er en sol d���mde bulunur.
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
                MessageBox.Show("A�a� bo�.");
            }
        }

        private string PreOrder(TreeNode node)
        {
            if (node == null)
            {
                return "";
            }

            // Gezilen d���m�n de�erini al
            string sonuc = node.Data + " ";

            // Sol alt a�aca git
            sonuc += PreOrder(node.Left);

            // Sa� alt a�aca git
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
                MessageBox.Show("A�a� bo�.");
            }
        }

        private string InOrder(TreeNode node)
        {
            if (node == null)
            {
                return "";
            }

            // Sol alt a�aca git
            string sonuc = InOrder(node.Left);

            // Gezilen d���m�n de�erini al
            sonuc += node.Data + " ";

            // Sa� alt a�aca git
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
                MessageBox.Show("A�a� bo�.");
            }
        }

        private string PostOrder(TreeNode node)
        {
            if (node == null)
            {
                return "";
            }

            // Sol alt a�aca git
            string sonuc = PostOrder(node.Left);

            // Sa� alt a�aca git
            sonuc += PostOrder(node.Right);

            // Gezilen d���m�n de�erini al
            sonuc += node.Data + " ";

            return sonuc;
        }
    }
}
