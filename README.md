# NET.UniversalSpeech
.NET version of qtnc / UniversalSpeech.

This release contains a various functions of Quentin C's UniversalSpeech exported from the UniversalSpeech.h. To use the NET.UniversalSpeech, you must to download the UniversalSpeech originally from the http://www.quentinc.net/UniversalSpeech website, or to clone the UniversalSpeech repository from:
https://github.com/qtnc/UniversalSpeech.git
Only the UniversalSpeech bynarries are included in this release.

If you want to contribute to NET.UniversalSpeech, please email me at:
daremc86@gmail.com

Using the NET.UniversalSpeech .NET assembly


The NET.UniversalSpeech is compiled in VS 2013, and is written in the C Sharp managed code.
To use the NET.UniversalSpeech, you need to add the reference to the NET.UniversalSpeech.dll.
Then, you need to add the following line in your code:
Using NET.UniversalSpeech;

If you want to use the enum SpeechParameters, you can access the enum outside an instantiation of the UniversalSpeech.class. For example:
UniversalSpeech.SpeechParameters.VoiceInflection;
But, if you want to access a method from the UniversalSpeechClass, you need to create an instance to the class, for example:
UniversalSpeech speech = new UniversalSpeech();


Then, you can access a method from the speech object of the UniversalSpeech class, for example:
speech.SpeechSay("Hello world!", 0);

You can see the practice of the NET.UniversalSpeech in the demonstration example in the Bin, and Source directory.

The rest documentation coming soon.

