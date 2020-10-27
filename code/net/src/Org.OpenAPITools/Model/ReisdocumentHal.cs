/* 
 * Reisdocumenten
 *
 * API voor het ontsluiten van gegevens van reisdocumenten uit de GBA en RNI.
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ReisdocumentHal
    /// </summary>
    [DataContract]
    public partial class ReisdocumentHal :  IEquatable<ReisdocumentHal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReisdocumentHal" /> class.
        /// </summary>
        /// <param name="aanduidingInhoudingOfVermissing">aanduidingInhoudingOfVermissing.</param>
        /// <param name="reisdocumentnummer">Het nummer van het verstrekte Nederlandse reisdocument..</param>
        /// <param name="autoriteitAfgifte">autoriteitAfgifte.</param>
        /// <param name="datumEindeGeldigheid">datumEindeGeldigheid.</param>
        /// <param name="datumInhoudingOfVermissing">datumInhoudingOfVermissing.</param>
        /// <param name="datumUitgifte">datumUitgifte.</param>
        /// <param name="soortReisdocument">soortReisdocument.</param>
        /// <param name="geheimhoudingPersoonsgegevens">Een aanduiding die aangeeft dat gegevens wel of niet verstrekt mogen worden. Indien true: op verzoek van deze persoon is het verstrekken van gegevens over deze persoon aan bepaalde derden niet toegestaan..</param>
        /// <param name="inOnderzoek">inOnderzoek.</param>
        /// <param name="links">links.</param>
        public ReisdocumentHal(AanduidingInhoudingVermissingReisdocumentEnum aanduidingInhoudingOfVermissing = default(AanduidingInhoudingVermissingReisdocumentEnum), string reisdocumentnummer = default(string), Waardetabel autoriteitAfgifte = default(Waardetabel), DatumOnvolledig datumEindeGeldigheid = default(DatumOnvolledig), DatumOnvolledig datumInhoudingOfVermissing = default(DatumOnvolledig), DatumOnvolledig datumUitgifte = default(DatumOnvolledig), Waardetabel soortReisdocument = default(Waardetabel), bool geheimhoudingPersoonsgegevens = default(bool), ReisdocumentInOnderzoek inOnderzoek = default(ReisdocumentInOnderzoek), ReisdocumentLinks links = default(ReisdocumentLinks))
        {
            this.AanduidingInhoudingOfVermissing = aanduidingInhoudingOfVermissing;
            this.Reisdocumentnummer = reisdocumentnummer;
            this.AutoriteitAfgifte = autoriteitAfgifte;
            this.DatumEindeGeldigheid = datumEindeGeldigheid;
            this.DatumInhoudingOfVermissing = datumInhoudingOfVermissing;
            this.DatumUitgifte = datumUitgifte;
            this.SoortReisdocument = soortReisdocument;
            this.GeheimhoudingPersoonsgegevens = geheimhoudingPersoonsgegevens;
            this.InOnderzoek = inOnderzoek;
            this.Links = links;
        }
        
        /// <summary>
        /// Gets or Sets AanduidingInhoudingOfVermissing
        /// </summary>
        [DataMember(Name="aanduidingInhoudingOfVermissing", EmitDefaultValue=false)]
        public AanduidingInhoudingVermissingReisdocumentEnum AanduidingInhoudingOfVermissing { get; set; }

        /// <summary>
        /// Het nummer van het verstrekte Nederlandse reisdocument.
        /// </summary>
        /// <value>Het nummer van het verstrekte Nederlandse reisdocument.</value>
        [DataMember(Name="reisdocumentnummer", EmitDefaultValue=false)]
        public string Reisdocumentnummer { get; set; }

        /// <summary>
        /// Gets or Sets AutoriteitAfgifte
        /// </summary>
        [DataMember(Name="autoriteitAfgifte", EmitDefaultValue=false)]
        public Waardetabel AutoriteitAfgifte { get; set; }

        /// <summary>
        /// Gets or Sets DatumEindeGeldigheid
        /// </summary>
        [DataMember(Name="datumEindeGeldigheid", EmitDefaultValue=false)]
        public DatumOnvolledig DatumEindeGeldigheid { get; set; }

        /// <summary>
        /// Gets or Sets DatumInhoudingOfVermissing
        /// </summary>
        [DataMember(Name="datumInhoudingOfVermissing", EmitDefaultValue=false)]
        public DatumOnvolledig DatumInhoudingOfVermissing { get; set; }

        /// <summary>
        /// Gets or Sets DatumUitgifte
        /// </summary>
        [DataMember(Name="datumUitgifte", EmitDefaultValue=false)]
        public DatumOnvolledig DatumUitgifte { get; set; }

        /// <summary>
        /// Gets or Sets SoortReisdocument
        /// </summary>
        [DataMember(Name="soortReisdocument", EmitDefaultValue=false)]
        public Waardetabel SoortReisdocument { get; set; }

        /// <summary>
        /// Een aanduiding die aangeeft dat gegevens wel of niet verstrekt mogen worden. Indien true: op verzoek van deze persoon is het verstrekken van gegevens over deze persoon aan bepaalde derden niet toegestaan.
        /// </summary>
        /// <value>Een aanduiding die aangeeft dat gegevens wel of niet verstrekt mogen worden. Indien true: op verzoek van deze persoon is het verstrekken van gegevens over deze persoon aan bepaalde derden niet toegestaan.</value>
        [DataMember(Name="geheimhoudingPersoonsgegevens", EmitDefaultValue=false)]
        public bool GeheimhoudingPersoonsgegevens { get; set; }

        /// <summary>
        /// Gets or Sets InOnderzoek
        /// </summary>
        [DataMember(Name="inOnderzoek", EmitDefaultValue=false)]
        public ReisdocumentInOnderzoek InOnderzoek { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public ReisdocumentLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReisdocumentHal {\n");
            sb.Append("  AanduidingInhoudingOfVermissing: ").Append(AanduidingInhoudingOfVermissing).Append("\n");
            sb.Append("  Reisdocumentnummer: ").Append(Reisdocumentnummer).Append("\n");
            sb.Append("  AutoriteitAfgifte: ").Append(AutoriteitAfgifte).Append("\n");
            sb.Append("  DatumEindeGeldigheid: ").Append(DatumEindeGeldigheid).Append("\n");
            sb.Append("  DatumInhoudingOfVermissing: ").Append(DatumInhoudingOfVermissing).Append("\n");
            sb.Append("  DatumUitgifte: ").Append(DatumUitgifte).Append("\n");
            sb.Append("  SoortReisdocument: ").Append(SoortReisdocument).Append("\n");
            sb.Append("  GeheimhoudingPersoonsgegevens: ").Append(GeheimhoudingPersoonsgegevens).Append("\n");
            sb.Append("  InOnderzoek: ").Append(InOnderzoek).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReisdocumentHal);
        }

        /// <summary>
        /// Returns true if ReisdocumentHal instances are equal
        /// </summary>
        /// <param name="input">Instance of ReisdocumentHal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReisdocumentHal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AanduidingInhoudingOfVermissing == input.AanduidingInhoudingOfVermissing ||
                    (this.AanduidingInhoudingOfVermissing != null &&
                    this.AanduidingInhoudingOfVermissing.Equals(input.AanduidingInhoudingOfVermissing))
                ) && 
                (
                    this.Reisdocumentnummer == input.Reisdocumentnummer ||
                    (this.Reisdocumentnummer != null &&
                    this.Reisdocumentnummer.Equals(input.Reisdocumentnummer))
                ) && 
                (
                    this.AutoriteitAfgifte == input.AutoriteitAfgifte ||
                    (this.AutoriteitAfgifte != null &&
                    this.AutoriteitAfgifte.Equals(input.AutoriteitAfgifte))
                ) && 
                (
                    this.DatumEindeGeldigheid == input.DatumEindeGeldigheid ||
                    (this.DatumEindeGeldigheid != null &&
                    this.DatumEindeGeldigheid.Equals(input.DatumEindeGeldigheid))
                ) && 
                (
                    this.DatumInhoudingOfVermissing == input.DatumInhoudingOfVermissing ||
                    (this.DatumInhoudingOfVermissing != null &&
                    this.DatumInhoudingOfVermissing.Equals(input.DatumInhoudingOfVermissing))
                ) && 
                (
                    this.DatumUitgifte == input.DatumUitgifte ||
                    (this.DatumUitgifte != null &&
                    this.DatumUitgifte.Equals(input.DatumUitgifte))
                ) && 
                (
                    this.SoortReisdocument == input.SoortReisdocument ||
                    (this.SoortReisdocument != null &&
                    this.SoortReisdocument.Equals(input.SoortReisdocument))
                ) && 
                (
                    this.GeheimhoudingPersoonsgegevens == input.GeheimhoudingPersoonsgegevens ||
                    (this.GeheimhoudingPersoonsgegevens != null &&
                    this.GeheimhoudingPersoonsgegevens.Equals(input.GeheimhoudingPersoonsgegevens))
                ) && 
                (
                    this.InOnderzoek == input.InOnderzoek ||
                    (this.InOnderzoek != null &&
                    this.InOnderzoek.Equals(input.InOnderzoek))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AanduidingInhoudingOfVermissing != null)
                    hashCode = hashCode * 59 + this.AanduidingInhoudingOfVermissing.GetHashCode();
                if (this.Reisdocumentnummer != null)
                    hashCode = hashCode * 59 + this.Reisdocumentnummer.GetHashCode();
                if (this.AutoriteitAfgifte != null)
                    hashCode = hashCode * 59 + this.AutoriteitAfgifte.GetHashCode();
                if (this.DatumEindeGeldigheid != null)
                    hashCode = hashCode * 59 + this.DatumEindeGeldigheid.GetHashCode();
                if (this.DatumInhoudingOfVermissing != null)
                    hashCode = hashCode * 59 + this.DatumInhoudingOfVermissing.GetHashCode();
                if (this.DatumUitgifte != null)
                    hashCode = hashCode * 59 + this.DatumUitgifte.GetHashCode();
                if (this.SoortReisdocument != null)
                    hashCode = hashCode * 59 + this.SoortReisdocument.GetHashCode();
                if (this.GeheimhoudingPersoonsgegevens != null)
                    hashCode = hashCode * 59 + this.GeheimhoudingPersoonsgegevens.GetHashCode();
                if (this.InOnderzoek != null)
                    hashCode = hashCode * 59 + this.InOnderzoek.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Reisdocumentnummer (string) maxLength
            if(this.Reisdocumentnummer != null && this.Reisdocumentnummer.Length > 9)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reisdocumentnummer, length must be less than 9.", new [] { "Reisdocumentnummer" });
            }

            
            yield break;
        }
    }

}
