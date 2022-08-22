# coding: utf-8

"""
    OpenAPI Petstore

    This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Generated by: https://openapi-generator.tech
"""

import re  # noqa: F401
import sys  # noqa: F401
import typing  # noqa: F401
import functools  # noqa: F401

from frozendict import frozendict  # noqa: F401

import decimal  # noqa: F401
from datetime import date, datetime  # noqa: F401
from frozendict import frozendict  # noqa: F401

from petstore_api import schemas  # noqa: F401


class Model200Response(
    schemas.AnyTypeSchema,
):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.

    model with an invalid class name for python, starts with a number
    """
    name = schemas.Int32Schema
    _class = schemas.StrSchema
    locals()["class"] = _class
    del locals()['_class']
    """
    NOTE:
    openapi/json-schema allows properties to have invalid python names
    The above local assignment allows the code to keep those invalid python names
    This allows properties to have names like 'some-name', '1 bad name'
    Properties with these names are omitted from the __new__ + _from_openapi_data signatures
    - __new__ these properties can be passed in as **kwargs
    - _from_openapi_data these are passed in in a dict in the first positional argument *arg
    If the property is required and was not passed in, an exception will be thrown
    """

    def __new__(
        cls,
        *args: typing.Union[dict, frozendict, str, date, datetime, int, float, decimal.Decimal, None, list, tuple, bytes],
        name: typing.Union[name, schemas.Unset] = schemas.unset,
        _configuration: typing.Optional[schemas.Configuration] = None,
        **kwargs: typing.Type[schemas.Schema],
    ) -> 'Model200Response':
        return super().__new__(
            cls,
            *args,
            name=name,
            _configuration=_configuration,
            **kwargs,
        )
