## Main components of .NET Core platform:

**CLR** - Common Language Runtime (platform specific) <br/>
**CoreFX** - *mostly* platform-agnostic, contains base types <br/>
**CTS** - Common Type System - describes all types and all constructs supported by runtime <br/>
**CLS** - Common Language Specification - subset of *CTS* which supported by all .NET aware languages <br/>

## .NET Assemblies

.NET Core binaries do not contain platform specific instructions. They contain instructions in **CIL** - Common Intermediate Language and metadata. **CIL** - contains platform agnostic instructions, **metadata** - contains data about types, **manifest** - contains information about an assembly and other referenced assemblies. Then this **CIL** code compiled to platform specific instructions by JIT compiler.