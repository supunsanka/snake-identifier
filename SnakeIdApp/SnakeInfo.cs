using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeIdApp
{
    public partial class SnakeInfo : Form
    {
        Dictionary<string, string[]> snakeInfo = new Dictionary<string, string[]>();
        public SnakeInfo()
        {
            InitializeComponent();
            snakeInfo.Add("Cobra", new string[] { "The king cobra (Ophiophagus hannah, also known as hamadryad) is a species of venomous snake in the family Elapidae. The venom of the king cobra consists primarily of neurotoxins, known as the haditoxin", "Cobra.jpg" });
            snakeInfo.Add("Russell's Viper", new string[] { "Russell's viper (Daboia russelii) is a species of venomous snake in the family Viperidae. Daboia is a monotypic genus of venomous Old World vipers. The single member species, D. russelii, is found in Asia throughout the Indian subcontinent, much of Southeast Asia, southern China and Taiwan.", "Russells_Viper.jpg" });
            snakeInfo.Add("Krait", new string[] { "The common krait (Bungarus caeruleus), also known as Indian krait or blue krait) is a species of venomous snake of the genus Bungarus found in the jungles of the Indian subcontinent.", "Krait.jpg" });
            snakeInfo.Add("Sea Snake", new string[] { "The Hydrophiinae, commonly known as Sea Snakes or coral reef snakes, are a subfamily of venomous elapid snakes that inhabit marine environments for most or all of their lives.", "Sea-Snake.jpg" });
            snakeInfo.Add("Hump Nosed viper", new string[] { "Hypnale hypnale is a venomous pitviper species endemic to India and Sri Lanka.", "Hump_nosed_viper.jpg" });
            snakeInfo.Add("Saw Scaled viper", new string[] { "Echis (сommon names: saw-scaled vipers, carpet vipers) is a genus of venomous vipers found in the dry regions of Africa, the Middle East, Pakistan, India, and Sri Lanka.", "Saw-scaled_Viper.jpg" });
        }

        public SnakeInfo(string snake_name):this()
        {
            this.Text = snake_name;
            lblSnake.Text = "Probable Snake: " + snake_name;
            string[] info = snakeInfo[snake_name];
            textBox1.Text = info[0];
            snakePicture.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SnakeImages", info[1]));
        }
    }
}
