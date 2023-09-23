using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Interface1
    {
        void fly() { }
    }
    internal class Interface2
    {
        void run() { }

    }
    class ClassB : Interface1
    {
        public static void TestMultipleNestedTry()
        {
            try // try1
            {
                try // try2
                {
                    try //try3
                    {
                        try //try4
                        {
                            throw new Exception("bla bla");
                        }
                        catch (Exception ex0)
                        {
                            throw new ApplicationException("ex0" + ex0.Message);
                        }//end of try4
                    }
                    catch (ApplicationException ex1)
                    {
                        throw new IndexOutOfRangeException("ex1" + ex1.Message);
                    }
                    catch (Exception ex2)
                    {
                        throw new Exception("ex2" + ex2.Message);
                    }//end of try3
                }
                catch (ApplicationException ex3)
                {
                    throw new DllNotFoundException("ex3" + ex3.Message);
                }
                catch (IndexOutOfRangeException ex4)
                {
                    throw new ArgumentNullException("ex4" + ex4.Message);
                }
                catch (Exception ex5)
                {
                    throw new Exception("ex5" + ex5.Message);
                }// end of try2
            }
            catch (ApplicationException ex6)
            {
                throw new ArgumentNullException("ex6" + ex6.Message);
            }
            catch (DllNotFoundException ex7)
            {
                throw new DllNotFoundException("ex7" + ex7.Message);
            }
            catch (ArgumentNullException ex8)
            {
                throw new ArgumentNullException("ex8" + ex8.Message);
            }
            catch (Exception ex9)
            {
                throw new ArgumentNullException("ex9" + ex9.Message);
            }// end of try1
        }
    }
}
