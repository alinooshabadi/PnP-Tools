//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PnPAutomationUI
{
    using System;
    using System.Collections.Generic;
    
    public partial class TestAuthenticationSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TestAuthenticationSet()
        {
            this.TestConfigurationSets = new HashSet<TestConfigurationSet>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public bool AppOnly { get; set; }
        public string AppId { get; set; }
        public string AppSecret { get; set; }
        public string User { get; set; }
        public string Domain { get; set; }
        public string Password { get; set; }
        public string CredentialManagerLabel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestConfigurationSet> TestConfigurationSets { get; set; }
    }
}
