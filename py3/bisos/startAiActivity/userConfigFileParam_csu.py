#!/bin/env python
# -*- coding: utf-8 -*-

""" #+begin_org
* ~[Summary]~ :: Read/write the =templatesBase= file parameter for =startAiActivity=.
#+end_org """

import os
import pathlib
import typing

from bisos.b import fp


_PAR_ROOT = os.path.expanduser('~/.config/bisos/startAiActivity')
_PAR_NAME = 'templatesBase'


def templatesBaseGet(override: typing.Optional[str] = None) -> typing.Optional[pathlib.Path]:
    if override:
        return pathlib.Path(override)
    val = fp.FileParamValueReadFrom(parRoot=_PAR_ROOT, parName=_PAR_NAME)
    if val is None:
        return None
    return pathlib.Path(val.strip())


def templatesBaseSet(value: str) -> None:
    fp.FileParamWriteTo(parRoot=_PAR_ROOT, parName=_PAR_NAME, parValue=value.strip())