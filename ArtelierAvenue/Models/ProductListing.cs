//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArtelierAvenue.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductListing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductListing()
        {
            this.ListingPictures = new HashSet<ListingPicture>();
        }
    
        public int ProductListingID { get; set; }
        public int ClientID { get; set; }
        public int ProductListingTypeID { get; set; }
        public string ProductListingName { get; set; }
        public string ProductListingDescription { get; set; }
        public decimal ProductListingPrice { get; set; }
        public System.DateTime ProductListingDate { get; set; }
        public Nullable<int> ProductListingStatusID { get; set; }
    
        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListingPicture> ListingPictures { get; set; }
        public virtual ListingStatu ListingStatu { get; set; }
    }
}
