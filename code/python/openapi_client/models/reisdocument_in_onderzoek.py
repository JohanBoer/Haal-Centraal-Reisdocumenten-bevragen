# coding: utf-8

"""
    Reisdocumenten

    API voor het ontsluiten van gegevens van reisdocumenten uit de GBA en RNI.  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six

from openapi_client.configuration import Configuration


class ReisdocumentInOnderzoek(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'aanduiding_inhouding_of_vermissing': 'bool',
        'autoriteit_afgifte': 'bool',
        'datum_einde_geldigheid': 'bool',
        'datum_inhouding_of_vermissing': 'bool',
        'datum_uitgifte': 'bool',
        'reisdocumentnummer': 'bool',
        'soort_reisdocument': 'bool',
        'datum_ingang_onderzoek': 'DatumOnvolledig'
    }

    attribute_map = {
        'aanduiding_inhouding_of_vermissing': 'aanduidingInhoudingOfVermissing',
        'autoriteit_afgifte': 'autoriteitAfgifte',
        'datum_einde_geldigheid': 'datumEindeGeldigheid',
        'datum_inhouding_of_vermissing': 'datumInhoudingOfVermissing',
        'datum_uitgifte': 'datumUitgifte',
        'reisdocumentnummer': 'reisdocumentnummer',
        'soort_reisdocument': 'soortReisdocument',
        'datum_ingang_onderzoek': 'datumIngangOnderzoek'
    }

    def __init__(self, aanduiding_inhouding_of_vermissing=None, autoriteit_afgifte=None, datum_einde_geldigheid=None, datum_inhouding_of_vermissing=None, datum_uitgifte=None, reisdocumentnummer=None, soort_reisdocument=None, datum_ingang_onderzoek=None, local_vars_configuration=None):  # noqa: E501
        """ReisdocumentInOnderzoek - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._aanduiding_inhouding_of_vermissing = None
        self._autoriteit_afgifte = None
        self._datum_einde_geldigheid = None
        self._datum_inhouding_of_vermissing = None
        self._datum_uitgifte = None
        self._reisdocumentnummer = None
        self._soort_reisdocument = None
        self._datum_ingang_onderzoek = None
        self.discriminator = None

        if aanduiding_inhouding_of_vermissing is not None:
            self.aanduiding_inhouding_of_vermissing = aanduiding_inhouding_of_vermissing
        if autoriteit_afgifte is not None:
            self.autoriteit_afgifte = autoriteit_afgifte
        if datum_einde_geldigheid is not None:
            self.datum_einde_geldigheid = datum_einde_geldigheid
        if datum_inhouding_of_vermissing is not None:
            self.datum_inhouding_of_vermissing = datum_inhouding_of_vermissing
        if datum_uitgifte is not None:
            self.datum_uitgifte = datum_uitgifte
        if reisdocumentnummer is not None:
            self.reisdocumentnummer = reisdocumentnummer
        if soort_reisdocument is not None:
            self.soort_reisdocument = soort_reisdocument
        if datum_ingang_onderzoek is not None:
            self.datum_ingang_onderzoek = datum_ingang_onderzoek

    @property
    def aanduiding_inhouding_of_vermissing(self):
        """Gets the aanduiding_inhouding_of_vermissing of this ReisdocumentInOnderzoek.  # noqa: E501

        Indicator die aangeeft of het corresponderende gegeven voor deze persoon in onderzoek is.  # noqa: E501

        :return: The aanduiding_inhouding_of_vermissing of this ReisdocumentInOnderzoek.  # noqa: E501
        :rtype: bool
        """
        return self._aanduiding_inhouding_of_vermissing

    @aanduiding_inhouding_of_vermissing.setter
    def aanduiding_inhouding_of_vermissing(self, aanduiding_inhouding_of_vermissing):
        """Sets the aanduiding_inhouding_of_vermissing of this ReisdocumentInOnderzoek.

        Indicator die aangeeft of het corresponderende gegeven voor deze persoon in onderzoek is.  # noqa: E501

        :param aanduiding_inhouding_of_vermissing: The aanduiding_inhouding_of_vermissing of this ReisdocumentInOnderzoek.  # noqa: E501
        :type: bool
        """

        self._aanduiding_inhouding_of_vermissing = aanduiding_inhouding_of_vermissing

    @property
    def autoriteit_afgifte(self):
        """Gets the autoriteit_afgifte of this ReisdocumentInOnderzoek.  # noqa: E501

        Indicator die aangeeft of het corresponderende gegeven voor deze persoon in onderzoek is.  # noqa: E501

        :return: The autoriteit_afgifte of this ReisdocumentInOnderzoek.  # noqa: E501
        :rtype: bool
        """
        return self._autoriteit_afgifte

    @autoriteit_afgifte.setter
    def autoriteit_afgifte(self, autoriteit_afgifte):
        """Sets the autoriteit_afgifte of this ReisdocumentInOnderzoek.

        Indicator die aangeeft of het corresponderende gegeven voor deze persoon in onderzoek is.  # noqa: E501

        :param autoriteit_afgifte: The autoriteit_afgifte of this ReisdocumentInOnderzoek.  # noqa: E501
        :type: bool
        """

        self._autoriteit_afgifte = autoriteit_afgifte

    @property
    def datum_einde_geldigheid(self):
        """Gets the datum_einde_geldigheid of this ReisdocumentInOnderzoek.  # noqa: E501

        Indicator die aangeeft of het corresponderende gegeven voor deze persoon in onderzoek is.  # noqa: E501

        :return: The datum_einde_geldigheid of this ReisdocumentInOnderzoek.  # noqa: E501
        :rtype: bool
        """
        return self._datum_einde_geldigheid

    @datum_einde_geldigheid.setter
    def datum_einde_geldigheid(self, datum_einde_geldigheid):
        """Sets the datum_einde_geldigheid of this ReisdocumentInOnderzoek.

        Indicator die aangeeft of het corresponderende gegeven voor deze persoon in onderzoek is.  # noqa: E501

        :param datum_einde_geldigheid: The datum_einde_geldigheid of this ReisdocumentInOnderzoek.  # noqa: E501
        :type: bool
        """

        self._datum_einde_geldigheid = datum_einde_geldigheid

    @property
    def datum_inhouding_of_vermissing(self):
        """Gets the datum_inhouding_of_vermissing of this ReisdocumentInOnderzoek.  # noqa: E501

        Indicator die aangeeft of het corresponderende gegeven voor deze persoon in onderzoek is.  # noqa: E501

        :return: The datum_inhouding_of_vermissing of this ReisdocumentInOnderzoek.  # noqa: E501
        :rtype: bool
        """
        return self._datum_inhouding_of_vermissing

    @datum_inhouding_of_vermissing.setter
    def datum_inhouding_of_vermissing(self, datum_inhouding_of_vermissing):
        """Sets the datum_inhouding_of_vermissing of this ReisdocumentInOnderzoek.

        Indicator die aangeeft of het corresponderende gegeven voor deze persoon in onderzoek is.  # noqa: E501

        :param datum_inhouding_of_vermissing: The datum_inhouding_of_vermissing of this ReisdocumentInOnderzoek.  # noqa: E501
        :type: bool
        """

        self._datum_inhouding_of_vermissing = datum_inhouding_of_vermissing

    @property
    def datum_uitgifte(self):
        """Gets the datum_uitgifte of this ReisdocumentInOnderzoek.  # noqa: E501

        Indicator die aangeeft of het corresponderende gegeven voor deze persoon in onderzoek is.  # noqa: E501

        :return: The datum_uitgifte of this ReisdocumentInOnderzoek.  # noqa: E501
        :rtype: bool
        """
        return self._datum_uitgifte

    @datum_uitgifte.setter
    def datum_uitgifte(self, datum_uitgifte):
        """Sets the datum_uitgifte of this ReisdocumentInOnderzoek.

        Indicator die aangeeft of het corresponderende gegeven voor deze persoon in onderzoek is.  # noqa: E501

        :param datum_uitgifte: The datum_uitgifte of this ReisdocumentInOnderzoek.  # noqa: E501
        :type: bool
        """

        self._datum_uitgifte = datum_uitgifte

    @property
    def reisdocumentnummer(self):
        """Gets the reisdocumentnummer of this ReisdocumentInOnderzoek.  # noqa: E501

        Indicator die aangeeft of het corresponderende gegeven voor deze persoon in onderzoek is.  # noqa: E501

        :return: The reisdocumentnummer of this ReisdocumentInOnderzoek.  # noqa: E501
        :rtype: bool
        """
        return self._reisdocumentnummer

    @reisdocumentnummer.setter
    def reisdocumentnummer(self, reisdocumentnummer):
        """Sets the reisdocumentnummer of this ReisdocumentInOnderzoek.

        Indicator die aangeeft of het corresponderende gegeven voor deze persoon in onderzoek is.  # noqa: E501

        :param reisdocumentnummer: The reisdocumentnummer of this ReisdocumentInOnderzoek.  # noqa: E501
        :type: bool
        """

        self._reisdocumentnummer = reisdocumentnummer

    @property
    def soort_reisdocument(self):
        """Gets the soort_reisdocument of this ReisdocumentInOnderzoek.  # noqa: E501

        Indicator die aangeeft of het corresponderende gegeven voor deze persoon in onderzoek is.  # noqa: E501

        :return: The soort_reisdocument of this ReisdocumentInOnderzoek.  # noqa: E501
        :rtype: bool
        """
        return self._soort_reisdocument

    @soort_reisdocument.setter
    def soort_reisdocument(self, soort_reisdocument):
        """Sets the soort_reisdocument of this ReisdocumentInOnderzoek.

        Indicator die aangeeft of het corresponderende gegeven voor deze persoon in onderzoek is.  # noqa: E501

        :param soort_reisdocument: The soort_reisdocument of this ReisdocumentInOnderzoek.  # noqa: E501
        :type: bool
        """

        self._soort_reisdocument = soort_reisdocument

    @property
    def datum_ingang_onderzoek(self):
        """Gets the datum_ingang_onderzoek of this ReisdocumentInOnderzoek.  # noqa: E501


        :return: The datum_ingang_onderzoek of this ReisdocumentInOnderzoek.  # noqa: E501
        :rtype: DatumOnvolledig
        """
        return self._datum_ingang_onderzoek

    @datum_ingang_onderzoek.setter
    def datum_ingang_onderzoek(self, datum_ingang_onderzoek):
        """Sets the datum_ingang_onderzoek of this ReisdocumentInOnderzoek.


        :param datum_ingang_onderzoek: The datum_ingang_onderzoek of this ReisdocumentInOnderzoek.  # noqa: E501
        :type: DatumOnvolledig
        """

        self._datum_ingang_onderzoek = datum_ingang_onderzoek

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, ReisdocumentInOnderzoek):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, ReisdocumentInOnderzoek):
            return True

        return self.to_dict() != other.to_dict()
