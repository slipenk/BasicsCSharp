using System;
namespace Lab_4
{
    class TestClass
    {

        void DoSmthg1(int x)
        {
            x = 25;
            x = x++;
        }

        void DoSmthg2(ref int x)
        {
            x = 25;
            x = x++;
        }

        void DoSmthg3(out int x)
        {
            x = 25;
            x = x++;
        }


        int z = 0;
        public void test1()
        {
            for (int i = 0; i < 10000000; ++i)
            {
                DoSmthg1(z);
            }
        }
        public void test2()
        {
            for (int i = 0; i < 10000000; ++i)
            {
                DoSmthg2(ref z);
            }
        }

        public void test3()
        {
            for (int i = 0; i < 10000000; ++i)
            {
                DoSmthg3(out z);
            }
        }

        ///
        ///
        ///
        ///
        ///
        ///
        /// 
        void DoSmthgClass1_v(Test1 x)
        {
            x = new Test1();
        }

        void DoSmthgClass1_r(ref Test1 x)
        {
            x = new Test1();
        }

        void DoSmthgClass1_o(out Test1 x)
        {
            x = new Test1();
        }

        void DoSmthgStruct1_v(TestS1 x)
        {
            x = new TestS1();
        }

        void DoSmthgStruct1_r(ref TestS1 x)
        {
            x = new TestS1();
        }

        void DoSmthgStruct1_o(out TestS1 x)
        {
            x = new TestS1();

        }


        Test1 t1 = new Test1(156, 123.8, "Salah", (float)17281.3, true, 156, 123.8, "Salah", (float)17281.3, true, 156, 123.8, "Salah", (float)17281.3, true, 156, 123.8, "Salah", (float)17281.3, true);
        TestS1 tS1 = new TestS1(156, 123.8, "Salah", (float)17281.3, true, 156, 123.8, "Salah", (float)17281.3, true, 156, 123.8, "Salah", (float)17281.3, true, 156, 123.8, "Salah", (float)17281.3, true);
     


        public void testClass1_v()
        {
            for (int i = 0; i < 10000000; ++i)
            {
                DoSmthgClass1_v(t1);
            }
        }

        public void testClass1_r()
        {
            for (int i = 0; i < 10000000; ++i)
            {
                DoSmthgClass1_r(ref t1);
            }
        }

        public void testClass1_o()
        {
            for (int i = 0; i < 10000000; ++i)
            {
                DoSmthgClass1_o(out t1);
            }
        }

        public void testStruct1_v()
        {
            for (int i = 0; i < 10000000; ++i)
            {
                DoSmthgStruct1_v(tS1);
            }
        }

        public void testStruct1_r()
        {
            for (int i = 0; i < 10000000; ++i)
            {
                DoSmthgStruct1_r(ref tS1);
            }
        }

        public void testStruct1_o()
        {
            for (int i = 0; i < 10000000; ++i)
            {
                DoSmthgStruct1_o(out tS1);
            }
        }



        ///
        ///
        ///
        ///
        ///
        ///
        /// 
        void DoSmthgClass2_v(Test2 x)
        {
            x = new Test2();
        }

        void DoSmthgClass2_r(ref Test2 x)
        {
            x = new Test2();
        }

        void DoSmthgClass2_o(out Test2 x)
        {
            x = new Test2();
        }

        void DoSmthgStruct2_v(TestS2 x)
        {
            x = new TestS2();
        }

        void DoSmthgStruct2_r(ref TestS2 x)
        {
            x = new TestS2();
        }

        void DoSmthgStruct2_o(out TestS2 x)
        {
            x = new TestS2();
        }


        Test2 t2 = new Test2(156, 123.8, "Salah", (float)17281.3, true, 156, 123.8, "Salah", (float)17281.3, true);
        TestS2 tS2 = new TestS2(156, 123.8, "Salah", (float)17281.3, true, 156, 123.8, "Salah", (float)17281.3, true);


        public void testClass2_v()
        {
            for (int i = 0; i < 10000000; ++i)
            {
                DoSmthgClass2_v(t2);
            }
        }

        public void testClass2_r()
        {
            for (int i = 0; i < 10000000; ++i)
            {
                DoSmthgClass2_r(ref t2);
            }
        }

        public void testClass2_o()
        {
            for (int i = 0; i < 10000000; ++i)
            {
                DoSmthgClass2_o(out t2);
            }
        }

        public void testStruct2_v()
        {
            for (int i = 0; i < 10000000; ++i)
            {
                DoSmthgStruct2_v(tS2);
            }
        }

        public void testStruct2_r()
        {
            for (int i = 0; i < 10000000; ++i)
            {
                DoSmthgStruct2_r(ref tS2);
            }
        }

        public void testStruct2_o()
        {
            for (int i = 0; i < 10000000; ++i)
            {
                DoSmthgStruct2_o(out tS2);
            }
        }


        ///
        ///
        ///
        ///
        ///
        ///
        /// 
        void DoSmthgClass3_v(Test3 x)
        {
            x = new Test3();
        }

        void DoSmthgClass3_r(ref Test3 x)
        {
            x = new Test3();
        }

        void DoSmthgClass3_o(out Test3 x)
        {
            x = new Test3();
        }


        void DoSmthgStruct3_v(TestS3 x)
        {
            x = new TestS3();
        }

        void DoSmthgStruct3_r(ref TestS3 x)
        {
            x = new TestS3();
        }

        void DoSmthgStruct3_o(out TestS3 x)
        {
            x = new TestS3();
        }


        Test3 t3 = new Test3(156, 123.8, "Salah", (float)17281.3, true);
        TestS3 tS3 = new TestS3(156, 123.8, "Salah", (float)17281.3, true);


        public void testClass3_v()
        {
            for (int i = 0; i < 10000000; ++i)
            {
                DoSmthgClass3_v(t3);
            }
        }

        public void testClass3_r()
        {
            for (int i = 0; i < 10000000; ++i)
            {
                DoSmthgClass3_r(ref t3);
            }
        }

        public void testClass3_o()
        {
            for (int i = 0; i < 10000000; ++i)
            {
                DoSmthgClass3_o(out t3);
            }
        }

        public void testStruct3_v()
        {
            for (int i = 0; i < 10000000; ++i)
            {
                DoSmthgStruct3_v(tS3);
            }
        }

        public void testStruct3_r()
        {
            for (int i = 0; i < 10000000; ++i)
            {
                DoSmthgStruct3_r(ref tS3);
            }
        }

        public void testStruct3_o()
        {
            for (int i = 0; i < 10000000; ++i)
            {
                DoSmthgStruct3_o(out tS3);
            }
        }




        class Test1
        {

            int i;
            double k;
            String s;
            float l;
            bool b;
            int i1;
            double k1;
            String s1;
            float l1;
            bool b1;
            int i2;
            double k2;
            String s2;
            float l2;
            bool b2;
            int i3;
            double k3;
            String s3;
            float l3;
            bool b3;

            public Test1() { }

            public Test1(int i, double k, String s, float l, bool b, int i1, double k1, String s1, float l1, bool b1, int i2, double k2, String s2, float l2, bool b2,
                int i3, double k3, String s3, float l3, bool b3)
            {
                this.i = i;
                this.k = k;
                this.s = s;
                this.l = l;
                this.b = b;
                this.i1 = i1;
                this.k1 = k1;
                this.s1 = s1;
                this.l1 = l1;
                this.b1 = b1;
                this.i2 = i2;
                this.k2 = k2;
                this.s2 = s2;
                this.l2 = l2;
                this.b2 = b2;
                this.i3 = i3;
                this.k3 = k3;
                this.s3 = s3;
                this.l3 = l3;
                this.b3 = b3;

            }
        }

        class Test2
        {

            int i;
            double k;
            String s;
            float l;
            bool b;
            int i1;
            double k1;
            String s1;
            float l1;
            bool b1;

            public Test2() { }

            public Test2(int i, double k, String s, float l, bool b, int i1, double k1, String s1, float l1, bool b1)
            {
                this.i = i;
                this.k = k;
                this.s = s;
                this.l = l;
                this.b = b;
                this.i1 = i1;
                this.k1 = k1;
                this.s1 = s1;
                this.l1 = l1;
                this.b1 = b1;
            }

        }

        class Test3
        {
            int i;
            double k;
            String s;
            float l;
            bool b;

            public Test3() { }

            public Test3(int i, double k, String s, float l, bool b)
            {
                this.i = i;
                this.k = k;
                this.s = s;
                this.l = l;
                this.b = b;
            }
        }

        struct TestS1
        {

            int i;
            double k;
            String s;
            float l;
            bool b;
            int i1;
            double k1;
            String s1;
            float l1;
            bool b1;
            int i2;
            double k2;
            String s2;
            float l2;
            bool b2;
            int i3;
            double k3;
            String s3;
            float l3;
            bool b3;

            public TestS1(int i, double k, String s, float l, bool b, int i1, double k1, String s1, float l1, bool b1, int i2, double k2, String s2, float l2, bool b2,
                int i3, double k3, String s3, float l3, bool b3)
            {
                this.i = i;
                this.k = k;
                this.s = s;
                this.l = l;
                this.b = b;
                this.i1 = i1;
                this.k1 = k1;
                this.s1 = s1;
                this.l1 = l1;
                this.b1 = b1;
                this.i2 = i2;
                this.k2 = k2;
                this.s2 = s2;
                this.l2 = l2;
                this.b2 = b2;
                this.i3 = i3;
                this.k3 = k3;
                this.s3 = s3;
                this.l3 = l3;
                this.b3 = b3;

            }
        }

        struct TestS2
        {

            int i;
            double k;
            String s;
            float l;
            bool b;
            int i1;
            double k1;
            String s1;
            float l1;
            bool b1;

            public TestS2(int i, double k, String s, float l, bool b, int i1, double k1, String s1, float l1, bool b1)
            {
                this.i = i;
                this.k = k;
                this.s = s;
                this.l = l;
                this.b = b;
                this.i1 = i1;
                this.k1 = k1;
                this.s1 = s1;
                this.l1 = l1;
                this.b1 = b1;
            }

        }

        struct TestS3
        {
            int i;
            double k;
            String s;
            float l;
            bool b;

            public TestS3(int i, double k, String s, float l, bool b)
            {
                this.i = i;
                this.k = k;
                this.s = s;
                this.l = l;
                this.b = b;
            }


        }

    }
}
