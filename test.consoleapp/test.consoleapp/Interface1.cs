﻿namespace test.consoleapp {

    public interface Interface1 {
        string Message { get; set; }
        string Name { get; set; }

    }

    public interface Interface2 {

        string Name { get; set; }
    }



    public class Class1 : Interface1 {
        public string Message { get; set; }
        public string Name { get; set; }

        public string OtherMessage { get; set; }
    }
}