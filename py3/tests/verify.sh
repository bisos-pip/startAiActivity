#!/bin/bash -i
#

# Safety check: must run from a directory named "tests" — the cleanup step
# rm -rf's AI-collaboration files, which would destroy real work if run
# from a non-tests directory by mistake.
if [[ "$(basename "$PWD")" != "tests" ]]; then
    echo "ERROR: verify.sh must be run from a directory named 'tests'." >&2
    echo "  Current PWD: $PWD" >&2
    echo "  The initial cleanup step would delete AI-collaboration files." >&2
    exit 1
fi

# Start from a known-clean state (silent — matches may be absent).
# Also wipe cwdConfig (.aiActivity.cs/) so bare-invocation tests
# can distinguish "activity persisted this run" from "leftover from
# earlier run."
lpDo eval rm -rf .claude AI-*.org CLAUDE.md AI-*.dormant CLAUDE.md.dormant .aiActivity.cs 2\>/dev/null

lpDo ls -a -C -F

lpDo aiActivity.cs -i userConfig_set --parName="templates" --parValue="/bisos/apps/defaults/ai-templates"           # BISOS DEFAULT
lpDo aiActivity.cs -i userConfig_get --parName="templates"
lpDo aiActivity.cs -i initiate --activity="xu-single"           # Install xu-single templates (auto-persists activity to cwdConfig)
lpDo ls -a -C -F
lpDo cat .aiActivity.cs/fps/activity/value           # EXPECT: xu-single (auto-persisted)
lpDo aiActivity.cs -i deClaudify           # Remove AI files from current directory
lpDo ls -a -C -F
# Bare initiate — activity resolved from cwdConfig (no --activity flag).
lpDo aiActivity.cs -i initiate           # EXPECT: uses activity=xu-single from cwdConfig
lpDo ls -a -C -F
lpDo aiActivity.cs -i aiSuspend
lpDo ls -a -C -F
lpDo aiActivity.cs -i aiResume
lpDo ls -a -C -F

# refresh coverage — base mode: normal re-copy of an already-safe-copied CLAUDE.md
lpDo aiActivity.cs -i refresh           # EXPECT: REFRESHED CLAUDE.md
lpDo ls -a -C -F

# refresh coverage — legacy symlink upgrade: replace CLAUDE.md with a symlink,
# then refresh should unlink and safe-copy (UPGRADED).
lpDo eval rm -f CLAUDE.md
lpDo ln -s /bisos/apps/defaults/ai-templates/mother/CLAUDE.md CLAUDE.md
lpDo ls -a -C -F
lpDo aiActivity.cs -i refresh           # EXPECT: UPGRADED (legacy symlink -> safe-copy)
lpDo ls -a -C -F

lpDo aiActivity.cs -i deClaudify           # Remove AI files from current directory
lpDo ls -a -C -F
lpDo aiActivity.cs -i initiateSub --activity="xu-single"
lpDo ls -a -C -F

# refresh coverage — sub mode: parent walk-up should detect sub, re-copy from
# mother/initiateSub/CLAUDE.md.
lpDo aiActivity.cs -i refresh           # EXPECT: MODE: sub; REFRESHED CLAUDE.md
lpDo ls -a -C -F

lpDo aiActivity.cs -i deClaudify           # Remove AI files from current directory
lpDo ls -a -C -F

# Negative-case tests for initiateSub — should refuse cleanly.
# 1. No initiated parent: run in a fresh /tmp dir outside the BISOS tree.
TMPDIR=$(mktemp -d)
lpDo pushd "$TMPDIR"
lpDo ls -a -C -F
lpDo aiActivity.cs -i initiateSub --activity="xu-single"           # EXPECT REFUSAL: No initiated parent found
lpDo ls -a -C -F
lpDo popd
lpDo eval rm -rf "$TMPDIR"
