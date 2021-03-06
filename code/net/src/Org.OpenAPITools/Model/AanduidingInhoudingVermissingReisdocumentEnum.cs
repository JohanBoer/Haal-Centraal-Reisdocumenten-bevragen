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
    /// De mogelijke waarden van de aanduiding van inhouding of vermissing van een Nederlands reisdocument. Zie logisch ontwerp BRP bij de stamtabellen: * &#x60;ingehouden_of_ingeleverd&#x60; - I * &#x60;vermist&#x60; - V * &#x60;rechtswege&#x60; - R * &#x60;niet_in_bezit_van&#x60; - N
    /// </summary>
    /// <value>De mogelijke waarden van de aanduiding van inhouding of vermissing van een Nederlands reisdocument. Zie logisch ontwerp BRP bij de stamtabellen: * &#x60;ingehouden_of_ingeleverd&#x60; - I * &#x60;vermist&#x60; - V * &#x60;rechtswege&#x60; - R * &#x60;niet_in_bezit_van&#x60; - N</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AanduidingInhoudingVermissingReisdocumentEnum
    {
        /// <summary>
        /// Enum Ingehoudenofingeleverd for value: ingehouden_of_ingeleverd
        /// </summary>
        [EnumMember(Value = "ingehouden_of_ingeleverd")]
        Ingehoudenofingeleverd = 1,

        /// <summary>
        /// Enum Vermist for value: vermist
        /// </summary>
        [EnumMember(Value = "vermist")]
        Vermist = 2,

        /// <summary>
        /// Enum Rechtswege for value: rechtswege
        /// </summary>
        [EnumMember(Value = "rechtswege")]
        Rechtswege = 3,

        /// <summary>
        /// Enum Nietinbezitvan for value: niet_in_bezit_van
        /// </summary>
        [EnumMember(Value = "niet_in_bezit_van")]
        Nietinbezitvan = 4

    }

}
