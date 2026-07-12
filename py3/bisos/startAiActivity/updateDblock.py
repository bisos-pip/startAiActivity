#!/bin/env python
# -*- coding: utf-8 -*-

""" #+begin_org
* ~[Summary]~ :: Build companion-docs list and drive =dblock_particulars= expansion.
#+end_org """

import pathlib
import typing

from bisos.startAiActivity import dblock_particulars

_COMPANION_CANDIDATES = [
    'AI-AGENTS.org',
    'AI-WORKFLOW.org',
    'AI-Activity.org',
    'AI-DevStatus.org',
    'README.org',
]


def expandParticulars(
        filePath: pathlib.Path,
        targetDir: pathlib.Path,
        activity: str,
) -> None:
    companionDocs = [
        f for f in _COMPANION_CANDIDATES
        if (targetDir / f).exists()
    ]
    dblock_particulars.expand(
        filePath=filePath,
        workingDir=targetDir,
        activity=activity,
        companionDocs=companionDocs,
    )
