/*
 * Reisdocumenten
 * API voor het ontsluiten van gegevens van reisdocumenten uit de GBA en RNI.
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import io.swagger.annotations.ApiModel;
import com.google.gson.annotations.SerializedName;

import java.io.IOException;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;

/**
 * De mogelijke waarden van de aanduiding van inhouding of vermissing van een Nederlands reisdocument. Zie logisch ontwerp BRP bij de stamtabellen: * &#x60;ingehouden_of_ingeleverd&#x60; - I * &#x60;vermist&#x60; - V * &#x60;rechtswege&#x60; - R * &#x60;niet_in_bezit_van&#x60; - N
 */
@JsonAdapter(AanduidingInhoudingVermissingReisdocumentEnum.Adapter.class)
public enum AanduidingInhoudingVermissingReisdocumentEnum {
  
  INGEHOUDEN_OF_INGELEVERD("ingehouden_of_ingeleverd"),
  
  VERMIST("vermist"),
  
  RECHTSWEGE("rechtswege"),
  
  NIET_IN_BEZIT_VAN("niet_in_bezit_van");

  private String value;

  AanduidingInhoudingVermissingReisdocumentEnum(String value) {
    this.value = value;
  }

  public String getValue() {
    return value;
  }

  @Override
  public String toString() {
    return String.valueOf(value);
  }

  public static AanduidingInhoudingVermissingReisdocumentEnum fromValue(String value) {
    for (AanduidingInhoudingVermissingReisdocumentEnum b : AanduidingInhoudingVermissingReisdocumentEnum.values()) {
      if (b.value.equals(value)) {
        return b;
      }
    }
    throw new IllegalArgumentException("Unexpected value '" + value + "'");
  }

  public static class Adapter extends TypeAdapter<AanduidingInhoudingVermissingReisdocumentEnum> {
    @Override
    public void write(final JsonWriter jsonWriter, final AanduidingInhoudingVermissingReisdocumentEnum enumeration) throws IOException {
      jsonWriter.value(enumeration.getValue());
    }

    @Override
    public AanduidingInhoudingVermissingReisdocumentEnum read(final JsonReader jsonReader) throws IOException {
      String value = jsonReader.nextString();
      return AanduidingInhoudingVermissingReisdocumentEnum.fromValue(value);
    }
  }
}

