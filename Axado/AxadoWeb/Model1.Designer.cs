﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("axadotestModel", "FK_classificacao_carriers", "classificacao_carriers", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(AxadoWeb.classificacao_carriers), "carriers", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(AxadoWeb.carrier), true)]

#endregion

namespace AxadoWeb
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class axadotestEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new axadotestEntities object using the connection string found in the 'axadotestEntities' section of the application configuration file.
        /// </summary>
        public axadotestEntities() : base("name=axadotestEntities", "axadotestEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new axadotestEntities object.
        /// </summary>
        public axadotestEntities(string connectionString) : base(connectionString, "axadotestEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new axadotestEntities object.
        /// </summary>
        public axadotestEntities(EntityConnection connection) : base(connection, "axadotestEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<carrier> carriers
        {
            get
            {
                if ((_carriers == null))
                {
                    _carriers = base.CreateObjectSet<carrier>("carriers");
                }
                return _carriers;
            }
        }
        private ObjectSet<carrier> _carriers;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<classificacao_carriers> classificacao_carriers
        {
            get
            {
                if ((_classificacao_carriers == null))
                {
                    _classificacao_carriers = base.CreateObjectSet<classificacao_carriers>("classificacao_carriers");
                }
                return _classificacao_carriers;
            }
        }
        private ObjectSet<classificacao_carriers> _classificacao_carriers;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the carriers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTocarriers(carrier carrier)
        {
            base.AddObject("carriers", carrier);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the classificacao_carriers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToclassificacao_carriers(classificacao_carriers classificacao_carriers)
        {
            base.AddObject("classificacao_carriers", classificacao_carriers);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="axadotestModel", Name="carrier")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class carrier : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new carrier object.
        /// </summary>
        /// <param name="id_carrier">Initial value of the id_carrier property.</param>
        public static carrier Createcarrier(global::System.Int32 id_carrier)
        {
            carrier carrier = new carrier();
            carrier.id_carrier = id_carrier;
            return carrier;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id_carrier
        {
            get
            {
                return _id_carrier;
            }
            set
            {
                if (_id_carrier != value)
                {
                    Onid_carrierChanging(value);
                    ReportPropertyChanging("id_carrier");
                    _id_carrier = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id_carrier");
                    Onid_carrierChanged();
                }
            }
        }
        private global::System.Int32 _id_carrier;
        partial void Onid_carrierChanging(global::System.Int32 value);
        partial void Onid_carrierChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                OntipoChanging(value);
                ReportPropertyChanging("tipo");
                _tipo = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("tipo");
                OntipoChanged();
            }
        }
        private global::System.String _tipo;
        partial void OntipoChanging(global::System.String value);
        partial void OntipoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String nome
        {
            get
            {
                return _nome;
            }
            set
            {
                OnnomeChanging(value);
                ReportPropertyChanging("nome");
                _nome = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("nome");
                OnnomeChanged();
            }
        }
        private global::System.String _nome;
        partial void OnnomeChanging(global::System.String value);
        partial void OnnomeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String endereco
        {
            get
            {
                return _endereco;
            }
            set
            {
                OnenderecoChanging(value);
                ReportPropertyChanging("endereco");
                _endereco = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("endereco");
                OnenderecoChanged();
            }
        }
        private global::System.String _endereco;
        partial void OnenderecoChanging(global::System.String value);
        partial void OnenderecoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String cidade
        {
            get
            {
                return _cidade;
            }
            set
            {
                OncidadeChanging(value);
                ReportPropertyChanging("cidade");
                _cidade = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("cidade");
                OncidadeChanged();
            }
        }
        private global::System.String _cidade;
        partial void OncidadeChanging(global::System.String value);
        partial void OncidadeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String estado
        {
            get
            {
                return _estado;
            }
            set
            {
                OnestadoChanging(value);
                ReportPropertyChanging("estado");
                _estado = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("estado");
                OnestadoChanged();
            }
        }
        private global::System.String _estado;
        partial void OnestadoChanging(global::System.String value);
        partial void OnestadoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String cpf
        {
            get
            {
                return _cpf;
            }
            set
            {
                OncpfChanging(value);
                ReportPropertyChanging("cpf");
                _cpf = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("cpf");
                OncpfChanged();
            }
        }
        private global::System.String _cpf;
        partial void OncpfChanging(global::System.String value);
        partial void OncpfChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String cnpj
        {
            get
            {
                return _cnpj;
            }
            set
            {
                OncnpjChanging(value);
                ReportPropertyChanging("cnpj");
                _cnpj = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("cnpj");
                OncnpjChanged();
            }
        }
        private global::System.String _cnpj;
        partial void OncnpjChanging(global::System.String value);
        partial void OncnpjChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String inscr_estadual
        {
            get
            {
                return _inscr_estadual;
            }
            set
            {
                Oninscr_estadualChanging(value);
                ReportPropertyChanging("inscr_estadual");
                _inscr_estadual = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("inscr_estadual");
                Oninscr_estadualChanged();
            }
        }
        private global::System.String _inscr_estadual;
        partial void Oninscr_estadualChanging(global::System.String value);
        partial void Oninscr_estadualChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String nro_placa
        {
            get
            {
                return _nro_placa;
            }
            set
            {
                Onnro_placaChanging(value);
                ReportPropertyChanging("nro_placa");
                _nro_placa = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("nro_placa");
                Onnro_placaChanged();
            }
        }
        private global::System.String _nro_placa;
        partial void Onnro_placaChanging(global::System.String value);
        partial void Onnro_placaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String estado_placa
        {
            get
            {
                return _estado_placa;
            }
            set
            {
                Onestado_placaChanging(value);
                ReportPropertyChanging("estado_placa");
                _estado_placa = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("estado_placa");
                Onestado_placaChanged();
            }
        }
        private global::System.String _estado_placa;
        partial void Onestado_placaChanging(global::System.String value);
        partial void Onestado_placaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> id_classificacao
        {
            get
            {
                return _id_classificacao;
            }
            set
            {
                Onid_classificacaoChanging(value);
                ReportPropertyChanging("id_classificacao");
                _id_classificacao = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("id_classificacao");
                Onid_classificacaoChanged();
            }
        }
        private Nullable<global::System.Int32> _id_classificacao;
        partial void Onid_classificacaoChanging(Nullable<global::System.Int32> value);
        partial void Onid_classificacaoChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("axadotestModel", "FK_classificacao_carriers", "classificacao_carriers")]
        public classificacao_carriers classificacao_carriers
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<classificacao_carriers>("axadotestModel.FK_classificacao_carriers", "classificacao_carriers").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<classificacao_carriers>("axadotestModel.FK_classificacao_carriers", "classificacao_carriers").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<classificacao_carriers> classificacao_carriersReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<classificacao_carriers>("axadotestModel.FK_classificacao_carriers", "classificacao_carriers");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<classificacao_carriers>("axadotestModel.FK_classificacao_carriers", "classificacao_carriers", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="axadotestModel", Name="classificacao_carriers")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class classificacao_carriers : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new classificacao_carriers object.
        /// </summary>
        /// <param name="id_classificacao">Initial value of the id_classificacao property.</param>
        public static classificacao_carriers Createclassificacao_carriers(global::System.Int32 id_classificacao)
        {
            classificacao_carriers classificacao_carriers = new classificacao_carriers();
            classificacao_carriers.id_classificacao = id_classificacao;
            return classificacao_carriers;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id_classificacao
        {
            get
            {
                return _id_classificacao;
            }
            set
            {
                if (_id_classificacao != value)
                {
                    Onid_classificacaoChanging(value);
                    ReportPropertyChanging("id_classificacao");
                    _id_classificacao = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id_classificacao");
                    Onid_classificacaoChanged();
                }
            }
        }
        private global::System.Int32 _id_classificacao;
        partial void Onid_classificacaoChanging(global::System.Int32 value);
        partial void Onid_classificacaoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                OntipoChanging(value);
                ReportPropertyChanging("tipo");
                _tipo = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("tipo");
                OntipoChanged();
            }
        }
        private global::System.String _tipo;
        partial void OntipoChanging(global::System.String value);
        partial void OntipoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String descricao
        {
            get
            {
                return _descricao;
            }
            set
            {
                OndescricaoChanging(value);
                ReportPropertyChanging("descricao");
                _descricao = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("descricao");
                OndescricaoChanged();
            }
        }
        private global::System.String _descricao;
        partial void OndescricaoChanging(global::System.String value);
        partial void OndescricaoChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("axadotestModel", "FK_classificacao_carriers", "carriers")]
        public EntityCollection<carrier> carriers
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<carrier>("axadotestModel.FK_classificacao_carriers", "carriers");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<carrier>("axadotestModel.FK_classificacao_carriers", "carriers", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}