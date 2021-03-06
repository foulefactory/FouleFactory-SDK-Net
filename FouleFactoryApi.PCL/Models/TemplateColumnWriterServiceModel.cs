/*
 * FouleFactoryApi.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 09/14/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using FouleFactoryApi.PCL;

namespace FouleFactoryApi.PCL.Models
{
    public class TemplateColumnWriterServiceModel : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int idTemplateColumnType;
        private int column;
        private int order;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("IdTemplateColumnType")]
        public int IdTemplateColumnType 
        { 
            get 
            {
                return this.idTemplateColumnType; 
            } 
            set 
            {
                this.idTemplateColumnType = value;
                onPropertyChanged("IdTemplateColumnType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Column")]
        public int Column 
        { 
            get 
            {
                return this.column; 
            } 
            set 
            {
                this.column = value;
                onPropertyChanged("Column");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Order")]
        public int Order 
        { 
            get 
            {
                return this.order; 
            } 
            set 
            {
                this.order = value;
                onPropertyChanged("Order");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 