using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace IoCPattern_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAppconfig_Click(object sender, EventArgs e)
        {
            
            var confs = ConfigurationManager.GetSection("databasePools") as DatabasePoolsSection;
            MessageBox.Show(confs.DatabasePools[0].Name + " -> " + confs.DatabasePools[0].Type,"Call from app.config");
        }

        private void btnSQLServer_Click(object sender, EventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
            var settings = config.GetSection("DatabaseSouces") as AppSettingsSection;

            AccessDBEngine objCustomer = new AccessDBEngine();
            var instance = Activator.CreateInstance(Type.GetType(settings.Settings["database"].Value));
            //var instance = Activator.CreateInstance(Type.GetType("IoCPattern.clsSQLServer,IoCPattern"));
            objCustomer.setDatabase((iDatabase)instance);
            objCustomer.save();
        }

        private void btnOracle_Click(object sender, EventArgs e)
        {
            AccessDBEngine objCustomer = new AccessDBEngine();
            //objCustomer.setDatabase(new clsSQLServer());
            objCustomer.setDatabase(new clsOracle());
            objCustomer.save();
        }
    }

    
    public interface iDatabase
    {
        void save();
    }

    
    public class clsSQLServer : iDatabase
    {
        public void save()
        {
            MessageBox.Show("Saving to SQL Server Database now.", "clsSQLServer");
        }
    }

    
    public class clsOracle : iDatabase
    {
        public void save()
        {
            MessageBox.Show("Saving to Oracle Database now.","clsOracle");
        }
    }

   
    public class AccessDBEngine
    {
        private iDatabase idatabase;

        public AccessDBEngine()
        {
            this.idatabase = null;
        }
        
        public AccessDBEngine(iDatabase database)
        {
            this.idatabase = database;
        }

        public iDatabase Database
        {
            get { return idatabase; }
            set { idatabase = value; }
        }

        public void save()
        {
            idatabase.save();
        }

        
        public void setDatabase(iDatabase database)
        {
            this.idatabase = database;
        }

    }

   
    public class DatabasePoolsSection : ConfigurationSection
    {
        [ConfigurationProperty("", IsRequired = true, IsDefaultCollection = true)]
        public DatabasePoolElementCollection DatabasePools
        {
            get
            {
                return (DatabasePoolElementCollection)this[""];
            }
        }
    }

    
    public class DatabasePoolElementCollection : ConfigurationElementCollection
    {
        protected override string ElementName
        {
            get
            {
                return "databasePool";
            }
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMap;
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new DatabasePoolElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((DatabasePoolElement)element).Name;
        }

        public DatabasePoolElement this[int index]
        {
            get
            {
                return (DatabasePoolElement)BaseGet(index);
            }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        new public DatabasePoolElement this[string name]
        {
            get
            {
                return (DatabasePoolElement)BaseGet(name);
            }
        }
    }

    
    public class DatabasePoolElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get
            {
                return (string)this["name"];
            }
            set
            {
                this["name"] = value;
            }
        }

        [ConfigurationProperty("type", IsRequired = true)]
        public string Type
        {
            get
            {
                return (string)this["type"];
            }
            set
            {
                this["type"] = value;
            }
        }

        [ConfigurationProperty("maxpoolcount", IsRequired = true)]
        public int MaxPoolCount
        {
            get
            {
                return (int)this["maxpoolcount"];
            }
            set
            {
                this["maxpoolcount"] = value;
            }
        }

    }
}
