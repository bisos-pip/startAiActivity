#!/bin/env python
# -*- coding: utf-8 -*-

""" #+begin_org
* ~[Summary]~ :: Pure-Python expander for the =b:ai:file/particulars= dblock.
#+end_org """

import pathlib
import re
import typing

_DBLOCK_RE = re.compile(
    r'(###\+BEGIN: b:ai:file/particulars[^\n]*\n).*?(###\+END:)',
    re.DOTALL,
)


def expand(
        filePath: pathlib.Path,
        workingDir: pathlib.Path,
        activity: str,
        companionDocs: typing.List[str],
) -> None:
    text = filePath.read_text()
    body = (
        f"* AI Working Context\n"
        f"  Working Directory: {workingDir}\n"
        f"  File: {filePath.resolve()}\n"
        f"  Activity: {activity}\n"
        f"  Companion Docs: {', '.join(companionDocs)}\n"
    )
    new_text = _DBLOCK_RE.sub(
        lambda m: m.group(1) + body + m.group(2),
        text,
    )
    filePath.write_text(new_text)
