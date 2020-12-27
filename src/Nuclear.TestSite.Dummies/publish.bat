@ECHO OFF

SET sn_exe="C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\sn.exe"
SET key=..\KeyPair.snk
SET bin=..\..\bin\Nuclear.TestSite.Dummies\AnyCPU\Release\netstandard2.0\
SET publish=..\..\publish\Nuclear.TestSite.Dummies\netstandard2.0\
SET dll=Nuclear.TestSite.Dummies.dll
SET pdb=Nuclear.TestSite.Dummies.pdb
SET xml=Nuclear.TestSite.Dummies.xml
SET deps=Nuclear.TestSite.Dummies.deps.json

REM delete publish dir
RMDIR /S /Q %publish%

REM resign assembly
%sn_exe% -Ra %bin%%dll% %key%

REM verify assembly in bin
%sn_exe% -vf %bin%%dll%

REM copy output to publish dir
robocopy %bin% %publish% %dll% %pdb% %xml% %deps%

REM verify assembly in publish
%sn_exe% -vf %publish%%dll%