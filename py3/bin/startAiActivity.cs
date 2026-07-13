#!/bin/env python
# -*- coding: utf-8 -*-

""" #+begin_org
* ~[Summary]~ :: A =CSXU= for initiating AI collaborative development templates.
#+end_org """

""" #+begin_org
* [[elisp:(org-cycle)][| ~Description~ |]] :: [[file:/bisos/panels/bisos-core/bisos-pip/bisos.tocsModules/_nodeBase_/fullUsagePanel-en.org][BISOS Panel]]   [[elisp:(org-cycle)][| ]]

** Status: In use with BISOS
** /[[elisp:(org-cycle)][| Planned Improvements |]]/ :
*** TODO Review Panel's Design and Evolution section.
#+end_org """


####+BEGIN: b:py3:cs:file/dblockControls :classification "cs-mu"
""" #+begin_org
* [[elisp:(org-cycle)][| /Control Parameters Of This File/ |]] :: dblk ctrls classifications=cs-mu
#+BEGIN_SRC emacs-lisp
(setq-local b:dblockControls t) ; (setq-local b:dblockControls nil)
(put 'b:dblockControls 'py3:cs:Classification "cs-mu") ; one of cs-mu, cs-u, cs-lib, bpf-lib, pyLibPure
#+END_SRC
#+RESULTS:
: cs-mu
#+end_org """
####+END:

####+BEGIN: b:prog:file/proclamations :outLevel 1
""" #+begin_org
* *[[elisp:(org-cycle)][| Proclamations |]]* :: Libre-Halaal Software --- Part Of BISOS ---  Poly-COMEEGA Format.
** This is Libre-Halaal Software. © Neda Communications, Inc. Subject to AGPL.
** It is part of BISOS (ByStar Internet Services OS)
** Best read and edited  with Blee in Poly-COMEEGA (Polymode Colaborative Org-Mode Enhance Emacs Generalized Authorship)
#+end_org """
####+END:

####+BEGIN: b:prog:file/particulars :authors ("./inserts/authors-mb.org")
""" #+begin_org
* *[[elisp:(org-cycle)][| Particulars |]]* :: Authors, version
** This File: /bisos/git/auth/bxRepos/bisos-pip/startAiActivity/py3/bin/startAiActivity.cs
** Authors: Mohsen BANAN, http://mohsen.banan.1.byname.net/contact
#+end_org """
####+END:

####+BEGIN: b:py3:file/particulars-csInfo :status "inUse"
""" #+begin_org
* *[[elisp:(org-cycle)][| Particulars-csInfo |]]*
#+end_org """
import typing
csInfo: typing.Dict[str, typing.Any] = { 'moduleName': ['startAiActivity'], }
csInfo['version'] = '202507111200'
csInfo['status']  = 'inUse'
csInfo['panel'] = 'startAiActivity-Panel.org'
csInfo['groupingType'] = 'IcmGroupingType-pkged'
csInfo['cmndParts'] = 'IcmCmndParts[common] IcmCmndParts[param]'
####+END:


####+BEGIN: b:prog:file/orgTopControls :outLevel 1
""" #+begin_org
* [[elisp:(org-cycle)][| Controls |]] :: [[elisp:(delete-other-windows)][(1)]] | [[elisp:(show-all)][Show-All]]  [[elisp:(org-shifttab)][Overview]]  [[elisp:(progn (org-shifttab) (org-content))][Content]] | [[file:Panel.org][Panel]] | [[elisp:(blee:ppmm:org-mode-toggle)][Nat]] | [[elisp:(bx:org:run-me)][Run]] | [[elisp:(bx:org:run-me-eml)][RunEml]] | [[elisp:(progn (save-buffer) (kill-buffer))][S&Q]]  [[elisp:(save-buffer)][Save]]  [[elisp:(kill-buffer)][Quit]] [[elisp:(org-cycle)][| ]]
** /Version Control/ ::  [[elisp:(call-interactively (quote cvs-update))][cvs-update]]  [[elisp:(vc-update)][vc-update]] | [[elisp:(bx:org:agenda:this-file-otherWin)][Agenda-List]]  [[elisp:(bx:org:todo:this-file-otherWin)][ToDo-List]]

#+end_org """
####+END:

####+BEGIN: b:py3:file/workbench :outLevel 1
""" #+begin_org
* [[elisp:(org-cycle)][| Workbench |]] :: [[elisp:(python-check (format "/bisos/venv/py3/bisos3/bin/python -m pyclbr %s" (bx:buf-fname))))][pyclbr]] || [[elisp:(python-check (format "/bisos/venv/py3/bisos3/bin/python -m pydoc ./%s" (bx:buf-fname))))][pydoc]] || [[elisp:(python-check (format "/bisos/pipx/bin/pyflakes %s" (bx:buf-fname)))][pyflakes]] | [[elisp:(python-check (format "/bisos/pipx/bin/pychecker %s" (bx:buf-fname))))][pychecker (executes)]] | [[elisp:(python-check (format "/bisos/pipx/bin/pycodestyle %s" (bx:buf-fname))))][pycodestyle]] | [[elisp:(python-check (format "/bisos/pipx/bin/flake8 %s" (bx:buf-fname))))][flake8]] | [[elisp:(python-check (format "/bisos/pipx/bin/pylint %s" (bx:buf-fname))))][pylint]]  [[elisp:(org-cycle)][| ]]
#+end_org """
####+END:

####+BEGIN: b:py3:cs:framework/imports :basedOn "classification"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CsFrmWrk   [[elisp:(outline-show-subtree+toggle)][||]] *Imports* =Based on Classification=cs-mu=
#+end_org """
from bisos import b
from bisos.b import cs
from bisos.b import b_io
from bisos.common import csParam

import collections
####+END:

import pathlib
import shutil
import subprocess
import typing

from bisos.pyDblock import updateDblock
import bisos.pyDblock.dblock_particulars  # registers b:ai:file/particulars handler

""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CsFrmWrk   [[elisp:(outline-show-subtree+toggle)][||]] ~csuList emacs-list Specifications~  [[elisp:(blee:org:code-block/above-run)][ /Eval Below/ ]] [[elisp:(org-cycle)][| ]]
#+BEGIN_SRC emacs-lisp
(setq  b:py:cs:csuList
  (list
   "bisos.b.userConfig_csu"
 ))
#+END_SRC
#+RESULTS:
| bisos.b.userConfig_csu |
#+end_org """

####+BEGIN: b:py3:cs:framework/csuListProc :pyImports t :csuImports t :csuParams t :csxuParams nil
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CsFrmWrk   [[elisp:(outline-show-subtree+toggle)][||]] ~Process CSU List~ with /1/ in csuList pyImports=t csuImports=t csuParams=t
#+end_org """

from bisos.b import userConfig_csu

csuList = [ 'bisos.b.userConfig_csu', ]

g_importedCmndsModules = cs.csuList_importedModules(csuList)

def g_extraParams():
    csParams = cs.param.CmndParamDict()
    cs.csuList_commonParamsSpecify(csuList, csParams)
    cs.argsparseBasedOnCsParams(csParams)

####+END:


####+BEGIN: b:py3:cs:orgItem/section :title "Common Parameters Specification"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  /Section/    [[elisp:(outline-show-subtree+toggle)][||]] *Common Parameters Specification*  [[elisp:(org-cycle)][| ]]
#+end_org """
####+END:

def commonParamsSpecify(
        csParams: cs.param.CmndParamDict,
) -> None:

    csParams.parDictAdd(
        parName='root',
        parDescription="Target root: 'repo' for repo base, 'curDir' for current project directory.",
        parDataType=None,
        parDefault='curDir',
        parChoices=['repo', 'curDir'],
        argparseShortOpt=None,
        argparseLongOpt='--root',
    )
    csParams.parDictAdd(
        parName='activity',
        parDescription="Template activity type matching a directory under <templatesBase>/.",
        parDataType=None,
        parDefault=None,
        parChoices=[],
        argparseShortOpt=None,
        argparseLongOpt='--activity',
    )
    csParams.parDictAdd(
        parName='templates',
        parDescription="Override templatesBase file parameter for this run.",
        parDataType=None,
        parDefault='/bisos/apps/defaults/ai-templates' if pathlib.Path('/bisos/apps/defaults/ai-templates').is_dir() else None,
        parChoices=[],
        argparseShortOpt=None,
        argparseLongOpt='--templates',
        parPermanence="userConfig",
    )


####+BEGIN: b:py3:cs:main/outcomeReportControl :disabled? nil :cmnd t :ro nil
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CsFrmWrk   [[elisp:(outline-show-subtree+toggle)][||]] ~Invokation's Outcome Reporting Control~ with /cmnd=t/ /ro=nil/
#+end_org """
# cs.invOutcomeReportControl(cmnd=True, ro=True)
####+END:


####+BEGIN: blee:bxPanel:foldingSection :outLevel 0 :sep nil :title "CmndSvcs" :anchor ""  :extraInfo "Command Services Section"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*     [[elisp:(outline-show-subtree+toggle)][| _CmndSvcs_: |]]  Command Services Section  [[elisp:(org-shifttab)][<)]] E|
#+end_org """
####+END:

####+BEGIN: b:py3:cs:cmnd/classHead :cmndName "examples" :extent "verify" :ro "noCli" :comment "FrameWrk: CS-Main-Examples" :parsMand "" :parsOpt "" :argsMin 0 :argsMax 0 :pyInv ""
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CmndSvc-   [[elisp:(outline-show-subtree+toggle)][||]] <<examples>>  *FrameWrk: CS-Main-Examples*  =verify= ro=noCli   [[elisp:(org-cycle)][| ]]
#+end_org """
class examples(cs.Cmnd):
    cmndParamsMandatory = [ ]
    cmndParamsOptional = [ ]
    cmndArgsLen = {'Min': 0, 'Max': 0,}
    rtInvConstraints = cs.rtInvoker.RtInvoker.new_noRo() # NO RO From CLI

    @cs.track(fnLoc=True, fnEntry=True, fnExit=True)
    def cmnd(self,
             rtInv: cs.RtInvoker,
             cmndOutcome: b.op.Outcome,
    ) -> b.op.Outcome:
        """FrameWrk: CS-Main-Examples"""
        failed = b_io.eh.badOutcome
        callParamsDict = {}
        if self.invocationValidate(rtInv, cmndOutcome, callParamsDict, None).isProblematic():
            return failed(cmndOutcome)
####+END:
        self.cmndDocStr(f""" #+begin_org
***** [[elisp:(org-cycle)][| *CmndDesc:* | ]]  Conventional top level example.
        #+end_org """)

        cs.examples.myName(cs.G.icmMyName(), cs.G.icmMyFullName())
        cs.examples.commonBrief()

        userConfig_csu.examples_csu().pyCmnd()

        od = collections.OrderedDict
        cmnd = cs.examples.cmndEnter

        templatesBaseStr = userConfig_csu.parGet('templates')

        cs.examples.menuChapter('=aiSuspend= / =aiResume= -- suspend and resume AI collaboration')
        cmnd('aiSuspend',
             pars=od([]),
             comment="# Remove symlinks/.claude, rename WorkPlan/DevStatus to .dormant")
        cmnd('aiResume',
             pars=od([]),
             comment="# Restore .dormant files and re-install symlinks/.claude")

        cs.examples.menuChapter('=deClaudify= -- remove AI collaboration files')
        cmnd('deClaudify',
             pars=od([]),
             comment="# Remove AI files from current directory")

        cs.examples.menuChapter('=initiate= *root=curDir* (default) -- install into current directory')
        if templatesBaseStr is None:
            cmnd('initiate',
                 pars=od([('root', 'curDir'), ('activity', '<activity>')]),
                 comment="# templates not set — run userConfig_set --parName=templates first")
        else:
            templatesBase = pathlib.Path(templatesBaseStr)
            excludedDirs = {'mother', 'startAiAt.cs', 'test'}
            activities = sorted([
                d.name for d in templatesBase.iterdir()
                if d.is_dir() and d.name not in excludedDirs
            ])
            for activity in activities:
                cmnd('initiate',
                     pars=od([('root', 'curDir'), ('activity', activity)]),
                     comment=f"# Install {activity} templates into current directory")

        cs.examples.menuChapter('=initiate= *root=repo* -- install at git repo base')
        if templatesBaseStr is not None:
            for activity in activities:
                cmnd('initiate',
                     pars=od([('root', 'repo'), ('activity', activity)]),
                     comment=f"# Install {activity} templates at repo base")

        return(cmndOutcome)



####+BEGIN: b:py3:cs:cmnd/classHead :cmndName "initiate" :comment "Install AI templates via symlinks and safe-copy" :extent "verify" :ro "cli" :parsMand "activity" :parsOpt "root templates" :argsMin 0 :argsMax 0 :pyInv ""
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CmndSvc-   [[elisp:(outline-show-subtree+toggle)][||]] <<initiate>>  =verify= parsMand=activity parsOpt="root templates" ro=cli   [[elisp:(org-cycle)][| ]]
#+end_org """
class initiate(cs.Cmnd):
    cmndParamsMandatory = [ 'activity', ]
    cmndParamsOptional = [ 'root', 'templates', ]
    cmndArgsLen = {'Min': 0, 'Max': 0,}

    @cs.track(fnLoc=True, fnEntry=True, fnExit=True)
    def cmnd(self,
             rtInv: cs.RtInvoker,
             cmndOutcome: b.op.Outcome,
             activity: typing.Optional[str]=None,   # Cs Mandatory Param
             root: typing.Optional[str]=None,        # Cs Optional Param
             templates: typing.Optional[str]=None,   # Cs Optional Param
    ) -> b.op.Outcome:

        failed = b_io.eh.badOutcome
        callParamsDict = {'activity': activity, 'root': root, 'templates': templates, }
        if self.invocationValidate(rtInv, cmndOutcome, callParamsDict, None).isProblematic():
            return failed(cmndOutcome)
        activity = csParam.mappedValue('activity', activity)
        root = csParam.mappedValue('root', root)
        templates = csParam.mappedValue('templates', templates)
####+END:
        self.cmndDocStr(f""" #+begin_org
** [[elisp:(org-cycle)][| *CmndDesc:* | ]]  Install AI collaborative development templates.
Symlinks constant files from mother/. Symlinks AI-Activity.org from <activity>/.
Safe-copies AI-DevStatus.org and AI-WorkPlan.org from <activity>/ (falling back to mother/).
Expands b:ai:file/particulars dblock in copied files using pure Python.
        #+end_org """)

        templatesBaseStr = userConfig_csu.parGet('templates', templates)
        if templatesBaseStr is None:
            b_io.eh.problem_usageError(
                "templates not configured. Run: startAiActivity.cs -i userConfig_set --parName=templates --parValue=/path/to/templates")
            return failed(cmndOutcome)
        templatesBase = pathlib.Path(templatesBaseStr)

        activityDir = templatesBase / activity
        if not activityDir.is_dir():
            b_io.eh.problem_usageError(f"Activity directory not found: {activityDir}")
            return failed(cmndOutcome)

        if root == 'repo':
            result = subprocess.run(
                ['git', 'rev-parse', '--show-toplevel'],
                capture_output=True, text=True,
            )
            if result.returncode != 0:
                b_io.eh.problem_usageError("Could not determine repo root (not in a git repo?)")
                return failed(cmndOutcome)
            targetDir = pathlib.Path(result.stdout.strip())
        else:
            targetDir = pathlib.Path.cwd()

        motherDir = templatesBase / 'mother'

        # Constant files — always symlinked to mother/
        constantFiles = ['CLAUDE.md', 'AI-AGENTS.org', 'AI-WORKFLOW.org']
        for fname in constantFiles:
            src = motherDir / fname
            dst = targetDir / fname
            if dst.exists() or dst.is_symlink():
                b_io.ann.note(f"SKIP (exists): {dst}")
            else:
                dst.symlink_to(src)
                b_io.ann.note(f"SYMLINKED: {dst} -> {src}")

        # AI-Activity.org — symlinked to activity/
        generalSrc = activityDir / 'AI-Activity.org'
        generalDst = targetDir / 'AI-Activity.org'
        if generalDst.exists() or generalDst.is_symlink():
            b_io.ann.note(f"SKIP (exists): {generalDst}")
        else:
            generalDst.symlink_to(generalSrc)
            b_io.ann.note(f"SYMLINKED: {generalDst} -> {generalSrc}")

        # Initial files — safe-copied from activity/, falling back to mother/
        initialFiles = ['AI-DevStatus.org', 'AI-WorkPlan.org']
        for fname in initialFiles:
            activitySrc = activityDir / fname
            motherSrc = motherDir / fname
            src = activitySrc if activitySrc.exists() else motherSrc
            dst = targetDir / fname
            if dst.exists():
                b_io.ann.note(f"SKIP (exists): {dst}")
            else:
                shutil.copy2(src, dst)
                b_io.ann.note(f"COPIED: {src} -> {dst}")
                updateDblock.expandAll(dst)
                b_io.ann.note(f"DBLOCK-UPDATED: {dst}")

        # .claude/ — activity-oriented symlinks so the same activity produces
        # identical .claude/ layouts across every project that uses it.
        # For each entry (settings.json file, commands/ directory), prefer the
        # activity's _claude/<entry> when present, else fall back to mother/_claude/<entry>.
        # settings.local.json is a per-machine overlay — never installed from templates.
        claudeDstDir = targetDir / '.claude'
        claudeDstDir.mkdir(exist_ok=True)

        for claudeEntry in ['settings.json', 'commands']:
            activityClaudeSrc = activityDir / '_claude' / claudeEntry
            motherClaudeSrc = motherDir / '_claude' / claudeEntry
            claudeSrc = activityClaudeSrc if activityClaudeSrc.exists() else motherClaudeSrc
            if not claudeSrc.exists():
                continue
            claudeDst = claudeDstDir / claudeEntry
            if claudeDst.exists() or claudeDst.is_symlink():
                b_io.ann.note(f"SKIP (exists): {claudeDst}")
            else:
                claudeDst.symlink_to(claudeSrc)
                b_io.ann.note(f"SYMLINKED: {claudeDst} -> {claudeSrc}")

        return cmndOutcome.set(
            opError=b.op.OpError.Success,
            opResults=f"AI templates initiated for activity={activity} at {targetDir}",
        )


####+BEGIN: b:py3:cs:cmnd/classHead :cmndName "aiSuspend" :comment "Suspend AI collaboration: remove symlinks/.claude, stash editable files" :extent "verify" :ro "cli" :parsMand "" :parsOpt "" :argsMin 0 :argsMax 0 :pyInv ""
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CmndSvc-   [[elisp:(outline-show-subtree+toggle)][||]] <<aiSuspend>>  =verify= ro=cli   [[elisp:(org-cycle)][| ]]
#+end_org """
class aiSuspend(cs.Cmnd):
    cmndParamsMandatory = [ ]
    cmndParamsOptional = [ ]
    cmndArgsLen = {'Min': 0, 'Max': 0,}

    @cs.track(fnLoc=True, fnEntry=True, fnExit=True)
    def cmnd(self,
             rtInv: cs.RtInvoker,
             cmndOutcome: b.op.Outcome,
    ) -> b.op.Outcome:

        failed = b_io.eh.badOutcome
        callParamsDict = {}
        if self.invocationValidate(rtInv, cmndOutcome, callParamsDict, None).isProblematic():
            return failed(cmndOutcome)
####+END:
        self.cmndDocStr(f""" #+begin_org
** [[elisp:(org-cycle)][| *CmndDesc:* | ]]  Suspend AI collaboration in current directory.
Removes symlinks (CLAUDE.md, AI-AGENTS.org, AI-WORKFLOW.org, AI-Activity.org)
and .claude/ entries. Renames AI-DevStatus.org and AI-WorkPlan.org to .dormant
so they survive and can be restored by aiResume.
        #+end_org """)

        targetDir = pathlib.Path.cwd()

        # Remove symlinks
        symlinkFiles = ['CLAUDE.md', 'AI-AGENTS.org', 'AI-WORKFLOW.org', 'AI-Activity.org']
        for fname in symlinkFiles:
            dst = targetDir / fname
            if dst.is_symlink():
                dst.unlink()
                b_io.ann.note(f"REMOVED symlink: {dst}")
            elif dst.exists():
                b_io.ann.note(f"SKIP (not a symlink, leaving intact): {dst}")
            else:
                b_io.ann.note(f"SKIP (not present): {dst}")

        # Stash editable files by renaming to .dormant
        stashFiles = ['AI-DevStatus.org', 'AI-WorkPlan.org']
        for fname in stashFiles:
            src = targetDir / fname
            dst = targetDir / (fname + '.dormant')
            if src.is_file() and not src.is_symlink():
                if dst.exists():
                    b_io.ann.note(f"SKIP stash (dormant already exists): {dst}")
                else:
                    src.rename(dst)
                    b_io.ann.note(f"STASHED: {src} -> {dst}")
            elif src.is_symlink():
                b_io.ann.note(f"SKIP stash (is a symlink, leaving intact): {src}")
            else:
                b_io.ann.note(f"SKIP stash (not present): {src}")

        # Remove .claude/ symlinked entries
        claudeDstDir = targetDir / '.claude'
        for claudeEntry in ['settings.json', 'commands']:
            claudeDst = claudeDstDir / claudeEntry
            if claudeDst.is_symlink():
                claudeDst.unlink()
                b_io.ann.note(f"REMOVED symlink: {claudeDst}")
            elif claudeDst.exists():
                b_io.ann.note(f"SKIP (not a symlink, leaving intact): {claudeDst}")
            else:
                b_io.ann.note(f"SKIP (not present): {claudeDst}")

        if claudeDstDir.is_dir() and not any(claudeDstDir.iterdir()):
            claudeDstDir.rmdir()
            b_io.ann.note(f"REMOVED empty directory: {claudeDstDir}")

        return cmndOutcome.set(
            opError=b.op.OpError.Success,
            opResults=f"aiSuspend complete at {targetDir}",
        )


####+BEGIN: b:py3:cs:cmnd/classHead :cmndName "aiResume" :comment "Resume AI collaboration: restore .dormant files and re-install symlinks/.claude" :extent "verify" :ro "cli" :parsMand "" :parsOpt "templates" :argsMin 0 :argsMax 0 :pyInv ""
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CmndSvc-   [[elisp:(outline-show-subtree+toggle)][||]] <<aiResume>>  =verify= parsOpt="templates" ro=cli   [[elisp:(org-cycle)][| ]]
#+end_org """
class aiResume(cs.Cmnd):
    cmndParamsMandatory = [ ]
    cmndParamsOptional = [ 'templates', ]
    cmndArgsLen = {'Min': 0, 'Max': 0,}

    @cs.track(fnLoc=True, fnEntry=True, fnExit=True)
    def cmnd(self,
             rtInv: cs.RtInvoker,
             cmndOutcome: b.op.Outcome,
             templates: typing.Optional[str]=None,   # Cs Optional Param
    ) -> b.op.Outcome:

        failed = b_io.eh.badOutcome
        callParamsDict = {'templates': templates, }
        if self.invocationValidate(rtInv, cmndOutcome, callParamsDict, None).isProblematic():
            return failed(cmndOutcome)
        templates = csParam.mappedValue('templates', templates)
####+END:
        self.cmndDocStr(f""" #+begin_org
** [[elisp:(org-cycle)][| *CmndDesc:* | ]]  Resume AI collaboration in current directory.
Restores AI-DevStatus.org and AI-WorkPlan.org from their .dormant copies.
Re-installs symlinks (CLAUDE.md, AI-AGENTS.org, AI-WORKFLOW.org, AI-Activity.org)
and .claude/ entries from the templates base. The activity is inferred from the
dormant AI-Activity.org symlink target if present, otherwise from the templates base.
        #+end_org """)

        targetDir = pathlib.Path.cwd()

        # Restore .dormant files
        stashFiles = ['AI-DevStatus.org', 'AI-WorkPlan.org']
        for fname in stashFiles:
            src = targetDir / (fname + '.dormant')
            dst = targetDir / fname
            if src.exists():
                if dst.exists() or dst.is_symlink():
                    b_io.ann.note(f"SKIP restore (already exists): {dst}")
                else:
                    src.rename(dst)
                    b_io.ann.note(f"RESTORED: {src} -> {dst}")
            else:
                b_io.ann.note(f"SKIP restore (dormant not found): {src}")

        # Determine templates base
        templatesBaseStr = userConfig_csu.parGet('templates', templates)
        if templatesBaseStr is None:
            b_io.eh.problem_usageError(
                "templates not configured. Run: startAiActivity.cs -i userConfig_set --parName=templates --parValue=/path/to/templates")
            return failed(cmndOutcome)
        templatesBase = pathlib.Path(templatesBaseStr)
        motherDir = templatesBase / 'mother'

        # Infer activity from AI-Activity.org symlink target if it still exists,
        # otherwise from the restored AI-WorkPlan.org dblock header, otherwise fail.
        activityOrg = targetDir / 'AI-Activity.org'
        activity = None
        if activityOrg.is_symlink():
            # target is <templatesBase>/<activity>/AI-Activity.org
            target = pathlib.Path(activityOrg.readlink())
            activity = target.parent.name
        else:
            # try to read Activity: line from AI-WorkPlan.org dblock header
            workPlan = targetDir / 'AI-WorkPlan.org'
            if workPlan.exists():
                for line in workPlan.read_text().splitlines():
                    if line.strip().startswith('Activity:'):
                        activity = line.split(':', 1)[1].strip()
                        break

        if activity is None:
            b_io.eh.problem_usageError(
                "Cannot infer activity. Ensure AI-Activity.org symlink or AI-WorkPlan.org with Activity: header is present.")
            return failed(cmndOutcome)

        activityDir = templatesBase / activity
        if not activityDir.is_dir():
            b_io.eh.problem_usageError(f"Activity directory not found: {activityDir}")
            return failed(cmndOutcome)

        b_io.ann.note(f"Inferred activity: {activity}")

        # Re-install constant symlinks
        constantFiles = ['CLAUDE.md', 'AI-AGENTS.org', 'AI-WORKFLOW.org']
        for fname in constantFiles:
            src = motherDir / fname
            dst = targetDir / fname
            if dst.exists() or dst.is_symlink():
                b_io.ann.note(f"SKIP (exists): {dst}")
            else:
                dst.symlink_to(src)
                b_io.ann.note(f"SYMLINKED: {dst} -> {src}")

        # Re-install AI-Activity.org symlink
        activitySrc = activityDir / 'AI-Activity.org'
        activityDst = targetDir / 'AI-Activity.org'
        if activityDst.exists() or activityDst.is_symlink():
            b_io.ann.note(f"SKIP (exists): {activityDst}")
        else:
            activityDst.symlink_to(activitySrc)
            b_io.ann.note(f"SYMLINKED: {activityDst} -> {activitySrc}")

        # Re-install .claude/ symlinked entries
        claudeDstDir = targetDir / '.claude'
        claudeDstDir.mkdir(exist_ok=True)
        for claudeEntry in ['settings.json', 'commands']:
            activityClaudeSrc = activityDir / '_claude' / claudeEntry
            motherClaudeSrc = motherDir / '_claude' / claudeEntry
            claudeSrc = activityClaudeSrc if activityClaudeSrc.exists() else motherClaudeSrc
            if not claudeSrc.exists():
                continue
            claudeDst = claudeDstDir / claudeEntry
            if claudeDst.exists() or claudeDst.is_symlink():
                b_io.ann.note(f"SKIP (exists): {claudeDst}")
            else:
                claudeDst.symlink_to(claudeSrc)
                b_io.ann.note(f"SYMLINKED: {claudeDst} -> {claudeSrc}")

        return cmndOutcome.set(
            opError=b.op.OpError.Success,
            opResults=f"aiResume complete at {targetDir} (activity={activity})",
        )


####+BEGIN: b:py3:cs:cmnd/classHead :cmndName "deClaudify" :comment "Remove AI collaboration files installed by initiate" :extent "verify" :ro "cli" :parsMand "" :parsOpt "" :argsMin 0 :argsMax 0 :pyInv ""
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CmndSvc-   [[elisp:(outline-show-subtree+toggle)][||]] <<deClaudify>>  =verify= ro=cli   [[elisp:(org-cycle)][| ]]
#+end_org """
class deClaudify(cs.Cmnd):
    cmndParamsMandatory = [ ]
    cmndParamsOptional = [ ]
    cmndArgsLen = {'Min': 0, 'Max': 0,}

    @cs.track(fnLoc=True, fnEntry=True, fnExit=True)
    def cmnd(self,
             rtInv: cs.RtInvoker,
             cmndOutcome: b.op.Outcome,
    ) -> b.op.Outcome:

        failed = b_io.eh.badOutcome
        callParamsDict = {}
        if self.invocationValidate(rtInv, cmndOutcome, callParamsDict, None).isProblematic():
            return failed(cmndOutcome)
####+END:
        self.cmndDocStr(f""" #+begin_org
** [[elisp:(org-cycle)][| *CmndDesc:* | ]]  Remove AI collaboration files installed by initiate.
Deletes symlinks: CLAUDE.md, AI-AGENTS.org, AI-WORKFLOW.org, AI-Activity.org,
.claude/settings.json, .claude/commands.
Deletes copied files: AI-DevStatus.org, AI-WorkPlan.org.
Removes .claude/ directory if it becomes empty.
        #+end_org """)

        targetDir = pathlib.Path.cwd()

        # Symlinked constant files and activity file
        symlinkFiles = ['CLAUDE.md', 'AI-AGENTS.org', 'AI-WORKFLOW.org', 'AI-Activity.org']
        for fname in symlinkFiles:
            dst = targetDir / fname
            if dst.is_symlink():
                dst.unlink()
                b_io.ann.note(f"REMOVED symlink: {dst}")
            elif dst.exists():
                b_io.ann.note(f"SKIP (not a symlink, leaving intact): {dst}")
            else:
                b_io.ann.note(f"SKIP (not present): {dst}")

        # Safe-copied files — only remove if they are regular files (not symlinks)
        copiedFiles = ['AI-DevStatus.org', 'AI-WorkPlan.org']
        for fname in copiedFiles:
            dst = targetDir / fname
            if dst.is_file() and not dst.is_symlink():
                dst.unlink()
                b_io.ann.note(f"REMOVED file: {dst}")
            elif dst.is_symlink():
                b_io.ann.note(f"SKIP (is a symlink, leaving intact): {dst}")
            else:
                b_io.ann.note(f"SKIP (not present): {dst}")

        # .claude/ symlinked entries
        claudeDstDir = targetDir / '.claude'
        for claudeEntry in ['settings.json', 'commands']:
            claudeDst = claudeDstDir / claudeEntry
            if claudeDst.is_symlink():
                claudeDst.unlink()
                b_io.ann.note(f"REMOVED symlink: {claudeDst}")
            elif claudeDst.exists():
                b_io.ann.note(f"SKIP (not a symlink, leaving intact): {claudeDst}")
            else:
                b_io.ann.note(f"SKIP (not present): {claudeDst}")

        # Remove .claude/ dir if now empty
        if claudeDstDir.is_dir() and not any(claudeDstDir.iterdir()):
            claudeDstDir.rmdir()
            b_io.ann.note(f"REMOVED empty directory: {claudeDstDir}")

        return cmndOutcome.set(
            opError=b.op.OpError.Success,
            opResults=f"deClaudify complete at {targetDir}",
        )


####+BEGIN: blee:bxPanel:foldingSection :outLevel 0 :sep nil :title "Main" :anchor ""  :extraInfo "Framework DBlock"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*     [[elisp:(outline-show-subtree+toggle)][| _Main_: |]]  Framework DBlock  [[elisp:(org-shifttab)][<)]] E|
#+end_org """
####+END:

####+BEGIN: b:py3:cs:framework/main :csInfo "csInfo" :noCmndEntry "examples" :extraParamsHook "g_extraParams" :importedCmndsModules "g_importedCmndsModules"
""" #+begin_org
*  _[[elisp:(blee:menu-sel:outline:popupMenu)][±]]_ _[[elisp:(blee:menu-sel:navigation:popupMenu)][Ξ]]_ [[elisp:(outline-show-branches+toggle)][|=]] [[elisp:(bx:orgm:indirectBufOther)][|>]] *[[elisp:(blee:ppmm:org-mode-toggle)][|N]]*  CsFrmWrk   [[elisp:(outline-show-subtree+toggle)][||]] =g_csMain= (csInfo, _examples_, g_extraParams, g_importedCmndsModules)
#+end_org """

if __name__ == '__main__':
    cs.main.g_csMain(
        csInfo=csInfo,
        noCmndEntry=examples,
        extraParamsHook=g_extraParams,
        ignoreUnknownParams=False,
        importedCmndsModules=g_importedCmndsModules,
    )

####+END:

####+BEGIN: b:py3:cs:framework/endOfFile :basedOn "classification"
""" #+begin_org
* [[elisp:(org-cycle)][| *End-Of-Editable-Text* |]] :: emacs and org variables and control parameters
#+end_org """

#+STARTUP: showall

### local variables:
### no-byte-compile: t
### end:
####+END:
