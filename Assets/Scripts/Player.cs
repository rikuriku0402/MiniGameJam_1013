using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Rigidbody2D _rb2d;

    int _jumpCount = 0;

    int _point;

    AudioSource _audio;

    [SerializeField]
    [Header("�R�C���̉�")]
    AudioClip _clip;

    [SerializeField]
    [Header("�W�����v�p���[")]
    float _jumpForce = 350f;

    [SerializeField]
    [Header("�ړ����x")]
    float _speed;

    [SerializeField]
    [Header("�|�C���g�e�L�X�g")]
    Text _coinText;

    [SerializeField]
    [Header("�Q�[���I�[�o�[�e�L�X�g")]
    Text _gameOverText;

    [SerializeField]
    [Header("�Q�[���I�[�o�[�{�^��")]
    Button _gameOverButton;

    private void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        _audio = GetComponent<AudioSource>();
    }
    private void Update()
    {
        float horizontalKey = Input.GetAxis("Horizontal");
        _rb2d.velocity = new Vector2(horizontalKey * _speed, _rb2d.velocity.y);


        if (horizontalKey < 0)
        {
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
        else if (horizontalKey > 0)
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.Space) && this._jumpCount < 1)
        {
            this._rb2d.AddForce(transform.up * _jumpForce);
            _jumpCount++;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            _point += 50;
            _coinText.text = _point.ToString();
            Destroy(collision.gameObject);
            _audio.PlayOneShot(_clip);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            _gameOverText.gameObject.SetActive(true);
            _gameOverText.text = "�Q�[���I�[�o�[";
            _gameOverButton.gameObject.SetActive(true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            _jumpCount = 0;
        }
    }
}
