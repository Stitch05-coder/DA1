using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
public class dangkytk : MonoBehaviour
{
    public TMP_InputField username;
    public TMP_InputField password;
    public TextMeshProUGUI thongbao;
    public string nameScene = "dangnhap";
    public void dangkybuton()
    {
        StartCoroutine(DangKy());
    }
    public void trovebuton()
    {
        SceneManager.LoadScene(nameScene);
    }
    IEnumerator DangKy()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", username.text);
        form.AddField("passwd", password.text);

        UnityWebRequest www = UnityWebRequest.Post("https://fpl.expvn.com/dangky.php",form);
        yield return www.SendWebRequest();

        if (!www.isDone)
        {
            thongbao.text = "Kết nối không thành công";
        }
        else {

            string get = www.downloadHandler.text;

            switch (get)
            {
                case "exist": thongbao.text = "Tài khoản đã tồn tại"; break;
                case "OK": thongbao.text = "Tài khoản đã đăng ký thành công"; break;
                case "ERROR": thongbao.text = "Đăng ký không thành công"; break;
               default: thongbao.text = "Không thể kết nối tới sever"; break;

            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
