using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataBinding.CarDealer
{
    public partial class CarDealer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var manifacturers = this.GetManufacturers();
                this.DropDownBrand.DataSource = manifacturers;
                this.DropDownBrand.SelectedIndex = 0;
                this.DropDownModel.DataSource = manifacturers[0].Models;

                var extras = GetExtras();
                this.CheckBoxListExtras.DataSource = extras;

                var engines = GetEngines();
                this.RadioButtonListEngines.DataSource = engines;
            }
        }

        private string[] GetEngines()
        {
            string[] engines = {"Petrol", "Diesel", "Hybrid", "Electric" };
            return engines;
        }

        private IList<Extra> GetExtras()
        {
            return new List<Extra>
            {
                new Extra{Name = "A/C"},
                new Extra{Name = "Automatic Headlights"},
                new Extra{Name = "Parktronic"},
                new Extra{Name = "ABS"},
                new Extra{Name = "Leather Interior"},
                new Extra{Name = "Multi-fuctional wheel"},
            };
        }


        protected void DropDownBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            var manifacturer = this.DropDownBrand.SelectedValue;
            var models = this.GetManufacturers().First(m => m.Name == manifacturer).Models;
            this.DropDownModel.DataSource = models;

            Page.DataBind();
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Page.DataBind();
        }

        private IList<Manufacturer> GetManufacturers()
        {
            var manifacturers = new List<Manufacturer>();

            var mercedes = new Manufacturer("Mercedes");
            mercedes.Models.Add(new Model() { Name = "A Class" });
            mercedes.Models.Add(new Model() { Name = "B Class" });
            mercedes.Models.Add(new Model() { Name = "C Class" });
            mercedes.Models.Add(new Model() { Name = "E Class" });
            mercedes.Models.Add(new Model() { Name = "S Class" });
            mercedes.Models.Add(new Model() { Name = "R Class" });

            var opel = new Manufacturer("Audi");
            opel.Models.Add(new Model() { Name = "A2" });
            opel.Models.Add(new Model() { Name = "A3" });
            opel.Models.Add(new Model() { Name = "A4" });
            opel.Models.Add(new Model() { Name = "A6" });
            opel.Models.Add(new Model() { Name = "A8" });

            var peugeot = new Manufacturer("Peugeot");
            peugeot.Models.Add(new Model { Name = "206" });
            peugeot.Models.Add(new Model { Name = "308" });
            peugeot.Models.Add(new Model { Name = "406" });
            peugeot.Models.Add(new Model { Name = "5008" });
            peugeot.Models.Add(new Model { Name = "607" });

            manifacturers.Add(mercedes);
            manifacturers.Add(opel);
            manifacturers.Add(peugeot);

            return manifacturers;
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            var selectedManufacturer = this.DropDownBrand.SelectedValue;
            var selectedModel = this.DropDownModel.SelectedValue;
            var extras = this.CheckBoxListExtras.Items;
            var selectedEngine = this.RadioButtonListEngines.SelectedValue;
            var selectedExtras = new List<string>();

            foreach (ListItem extra in extras)
            {
                if (extra.Selected)
                {
                    selectedExtras.Add(extra.Value);
                }
            }

            this.LiteralCarDetails.Text = string.Format("Manufacturer: {0}; Model: {1}; Engine: {2}; Extras: {3}",
                selectedManufacturer, selectedModel, selectedEngine, string.Join(" ", selectedExtras));
        }
    }
}