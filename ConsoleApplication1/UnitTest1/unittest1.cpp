#include "stdafx.h"
#include "CppUnitTest.h"
#include "../ConsoleApplication1/dc.h"


using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace UnitTest1
{		
	TEST_CLASS(UnitTest1)
	{
	public:
		
		TEST_METHOD(TestMethod1)
		{
			
			// TODO: 在此输入测试代码
			Assert::AreEqual(110, abc(5, 6));

		}

	};
}