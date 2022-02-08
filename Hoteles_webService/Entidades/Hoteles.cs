using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;

namespace Hoteles_webService.Entidades
{
    [Serializable]
    public partial class Hoteles
    {
        public Hoteles()
        {
        }

        public Hoteles(Nullable<System.Int32> id_hotel, System.String ciudad, Nullable<System.Int32> id_estandar, Nullable<System.Int32> hab_estandar
            , Nullable<System.Int32> id_vip, Nullable<System.Int32> hab_vip, Nullable<System.Int32> id_premium, Nullable<System.Int32> hab_premium
            , Nullable<System.Int32> cupo)
        {
            this.id_hotelField = id_hotel;
            this.ciudadField = ciudad;
            this.id_estandarField = id_estandar;
            this.hab_estandarField = hab_estandar;
            this.id_vipField = id_vip;
            this.hab_vipField = hab_vip;
            this.id_premiumField = id_premium;
            this.hab_premiumField = hab_premium;
            this.cupoField = cupo;
        }

        private Nullable<System.Int32> id_hotelField;
        public Nullable<System.Int32> id_hotel
        {
            get { return this.id_hotelField; }
            set { this.id_hotelField = value; }
        }

        private System.String ciudadField;
        public System.String ciudad
        {
            get { return this.ciudadField; }
            set { this.ciudadField = value; }
        }

        private Nullable<System.Int32> id_estandarField;
        public Nullable<System.Int32> id_estandar
        {
            get { return this.id_estandarField; }
            set { this.id_estandarField = value; }
        }

        private Nullable<System.Int32> hab_estandarField;
        public Nullable<System.Int32> hab_estandar
        {
            get { return this.hab_estandarField; }
            set { this.hab_estandarField = value; }
        }

        private Nullable<System.Int32> id_vipField;
        public Nullable<System.Int32> id_vip
        {
            get { return this.id_vipField; }
            set { this.id_vipField = value; }
        }

        private Nullable<System.Int32> hab_vipField;
        public Nullable<System.Int32> hab_vip
        {
            get { return this.hab_vipField; }
            set { this.hab_vipField = value; }
        }

        private Nullable<System.Int32> id_premiumField;
        public Nullable<System.Int32> id_premium
        {
            get { return this.id_premiumField; }
            set { this.id_premiumField = value; }
        }

        private Nullable<System.Int32> hab_premiumField;
        public Nullable<System.Int32> hab_premium
        {
            get { return this.hab_premiumField; }
            set { this.hab_premiumField = value; }
        }

        private Nullable<System.Int32> cupoField;
        public Nullable<System.Int32> cupo
        {
            get { return this.cupoField; }
            set { this.cupoField = value; }
        }
    }
}