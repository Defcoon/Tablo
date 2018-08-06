using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Periyodik_Tablo_V._1
{
    public partial class Bilimadamları : Form
    {
        public Bilimadamları()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fransız kimyacı olup 1808 de saf bir kimyasal maddeyi oluşturan elementlerin arasında sabit bir oran olduğunu kanıtlamıştır. Proust ''Sabit Oranlar Kanunu'' nu ortaya koyan bilim insanıdır.");    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilim dünyasında yanma olayına ilişkin geliştirdiği '' Kütlenin Korunumu Kanunu'' kuramıyla ün kazanmıştır. Kimya bilimine mantıksal düzen ve kuramsal açıklama yönlerinden katkılar sağlamıştır. Fransız ihtilali'nde bu devrimin getirdiği terörün kurbanı olur. Devrim adına idam edilir.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İngiliz kimyager John Dalton hazırladığı atom teorisi ile modern kimyanın temellerini oluşturmuştur. Ortaya koyduğu atom teorisi bugün geçerliliğini yitirse bile kimya için önemli bir adım sayılmıştır. John Dalton birçok elementin atomlarının ağırlığını ölçmeye çalışmış ve bu ağırlıklarla ilgili tablo hazırlamıştır. bileşikleri oluşturan elementlerin kütleleri arasındaki ilişkiyi incelemiş ve aynı elementlerden oluşan farklı bileşiklerdeki tam sayılarla ifade edilen oranı '' Katlı Oranlar Kanunu'' olarak ortaya koymuştur. Bunun dışında ''Kısmi Basınçlar Kanunu'' nu da açıklamıştır.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Genellikle gaz yasaları ile ilgili çalışmalar yapmıştır. Jacques Charles'in çalışmalarını kullanarak Charles Yasası olarak bilinen yasayı formülize etmiştir. Gazlarda Basınç- Sıcaklık ilişkisini incelemiş ve aralarında doğru orantı olduğunu bulmuştur. Buna '' Gay-Lussac kanunu denir. Bor elementini ilk kez saflaştıran bilim adamıdır.");
        }
    }
}
