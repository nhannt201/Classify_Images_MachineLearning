 # Classify Images Machine Learning  
![Classify Images Machine Learning](https://i.imgur.com/XqoVdi2.jpg)
## Introduction
 - Author: Nguyen Trung Nhan   
- Based on ML.NET sample at https://github.com/dotnet/machinelearning-samples/blob/master/README.md  
- My git: https://github.com/nhannt201  
## How to use this form?
- You need to download additional data and extract in `\bin\Debug\netcoreapp3.1`  
Download: https://www.mediafire.com/file/gp8u7a2c0jxeaad/netcoreapp3.1.zip/file  
To create machine learning data to classify images, see more at: https://dotnet.microsoft.com/learn/ml-dotnet/get-started-tutorial/intro  
## Instructions for using this form  
>Replace `C:\Users\lenovo\Desktop\Scan\` to folder containing the images to your classification!  
>Replace `C:\Users\lenovo\Desktop\Result\` to Result folder in the Guide folder  
## This sample identification:
- People (ConNguoi)
- Animals (DongVat)
- Items (DoVat)
- Flowers (Hoa)
- Document (TaiLieu)
- Nature (ThienNhien)
- Food (ThucAn)

You must not rename in the Result folder, the classification may be corrupted!  
You can `Console.WriteLine` Name of images with `result.Prediction`  
## Example of using this form:
First, the image will be loaded into the program:  
  `var input = new ModelInput ();`   
  `input.ImageSource = <your_image_url>;`  
  `// Load model and predict output of sample data`  
  `ModelOutput result = ConsumeModel.Predict (input);`    
Finally, result.Prediction is the name of the image classified based on the above 7 neu characteristics.  

Goodluck!


