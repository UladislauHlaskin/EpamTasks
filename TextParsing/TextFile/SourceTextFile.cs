using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextParsing.TextFile
{
    public class SourceTextFile
    {
        public string FilePath { get; }
        private int _currentLine;
        private static readonly string _defaultFilePath = @"source.txt";
        private static readonly string _defaultText = 
            @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed et dolor dapibus, vehicula nunc porta, mattis lacus. Etiam dolor arcu, rhoncus a enim sed, malesuada 
fermentum est. Sed commodo orci non faucibus finibus. In et tortor quis erat euismod facilisis non at orci. Etiam varius quis nibh eget venenatis. Vivamus nec lacus 
auctor tellus laoreet egestas id eget nunc. Nunc sed ex nulla. Vestibulum fermentum tristique risus eget posuere. Nam ac ullamcorper nulla. Orci varius natoque 
penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus ut justo in arcu ullamcorper malesuada at eu elit. Nam eu luctus odio.

Ut malesuada facilisis magna. Vivamus ullamcorper leo eu varius finibus. Duis mi eros, pretium nec dignissim a, pharetra a ligula. Vestibulum ac sapien at libero 
sodales auctor. Vestibulum varius ultrices nulla. Morbi pellentesque, purus at imperdiet laoreet, nunc turpis eleifend nisi, a imperdiet justo nisi a ante. Sed mattis 
imperdiet lectus at hendrerit. Curabitur auctor efficitur eros. Morbi auctor facilisis dui.

Nullam cursus, augue eu convallis interdum, odio nisl rhoncus lectus, in euismod tortor urna et mauris. Aliquam sed accumsan nisl, nec molestie odio. Vestibulum ornare
neque vel mi finibus dignissim. Integer ultricies sapien mi, at rhoncus orci condimentum nec. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras quis ligula 
luctus, faucibus eros et, vehicula sapien. Cras auctor mollis dolor, at aliquet diam aliquam quis. Duis lobortis arcu commodo magna varius dapibus. Integer in convallis 
neque. Vestibulum urna lectus, lacinia mattis facilisis sed, tempus eu lectus. Cras rhoncus commodo scelerisque. Quisque ultrices mollis erat vitae pharetra.

Ut sollicitudin sem quis neque vehicula laoreet ultricies vel urna. Donec nec orci lectus. Phasellus posuere nec velit sed cursus. Pellentesque habitant morbi tristique 
senectus et netus et malesuada fames ac turpis egestas. Morbi sem felis, accumsan non viverra a, efficitur vitae ex. Nulla ac molestie dolor. In hac habitasse platea 
dictumst. Aliquam lacinia felis et egestas sollicitudin. Donec sagittis massa ac pulvinar fringilla. Cras augue risus, imperdiet vitae porta ac, pretium non magna. Integer 
vehicula justo id odio sodales hendrerit. Nulla molestie massa neque, quis efficitur lorem pretium eu. Donec semper magna pharetra felis vehicula, sit amet scelerisque risus 
iaculis. In consequat mauris a volutpat efficitur. Proin vulputate luctus metus, a porttitor tellus. Donec in massa vel turpis accumsan eleifend vel at ex.

Aliquam consequat lacus pulvinar nisi commodo viverra. Curabitur porta purus ac ullamcorper placerat. Vestibulum condimentum velit eu velit imperdiet dapibus. Morbi in 
tortor vel quam molestie placerat. Aenean suscipit diam vel eros consectetur, eu finibus dui aliquam. Praesent nec massa pharetra diam pulvinar pretium eu vitae mi. Nulla 
euismod convallis neque, eu congue enim dapibus ut. Nunc efficitur felis sit amet tempor condimentum. Maecenas enim dui, molestie at sapien eget, aliquam volutpat nibh. 
Maecenas pretium justo non nibh dictum fermentum. Ut facilisis libero non augue placerat tempus.";
        public SourceTextFile()
        {
            //a default file with some text
            if (!File.Exists(_defaultFilePath))
            {
                File.WriteAllText(_defaultFilePath, _defaultText);
                FilePath = _defaultFilePath;
                _currentLine = 0;
            }
        }
        public SourceTextFile(string filePath)
        {
            FilePath = filePath;
            _currentLine = 0;
        }
        public List<string> ReadLines(int lines)
        {
            // reading
            var strings = File.ReadLines(FilePath).Skip(_currentLine).Take(lines).ToList();
            _currentLine += lines;
            return strings;
        }
    }
}
