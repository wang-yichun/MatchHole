using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//using System.Drawing;
//using System.IO;

public class Controller : MonoBehaviour
{
	
	public void button_clicked ()
	{
		Debug.Log ("button_clicked");
		
		//		Image image = Image.FromFile("/Users/leadprogrammer/Documents/bigmap.png");
		//
		//		byte[] a = imageToByteArray (image);

		StartCoroutine (WaitLoad ("file:///Users//leadprogrammer//Documents//UnityProject//MatchHole//pic_a//1.png"));

//		GameObject obj = GameObject.Find ("MySprite");
//		obj.renderer.material.mainTexture = wwwTexture;
//		obj.renderer.material.mainTexture = wwwTexture.texture;
	}
	
	//	public byte[] imageToByteArray(System.Drawing.Image imageIn)
	//	{
	//		MemoryStream ms = new MemoryStream();
	//		imageIn.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
	//		return ms.ToArray();
	//	}

	IEnumerator WaitLoad (string fileName)
	{
		WWW wwwTexture = new WWW (fileName);
		
		Debug.Log (wwwTexture.url);
		
		yield return wwwTexture;

		Texture2D texture = wwwTexture.texture;
		Color color = texture.GetPixel (600, 500);

		RawImage myImage = GameObject.Find ("MyRawImage").GetComponent<RawImage> ();
		myImage.texture = texture;
	}
}
